using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Timers;
using AnimeNorth.Data;

namespace AnimeNorth.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        IAnimeRepository AnimeRepository;
        private string Answer { get; set; }
        private List<Button> buttons = new List<Button>();
        private List<string> options = new List<string>();
        private int lifeLeft = 4;
        private int Score = 0;
        DeviceTimer deviceTimer;

        public Home()
        {
            InitializeComponent();
            AnimeRepository = new AnimeRepository();
        }

        protected  override void OnAppearing()
        {
             SetUpRound();
        }

        private async void SetUpRound()
        {

            // clear the options and answer 
            buttons.Clear();
            Answer = "";
            timerGuagePointer.Value = 0;

            // set options : wrap the awaited task within a task to make it wait
            this.buttons = Task.Run(async () => await SetDummmyOptionsAsync()).Result;

            // set new synopsis
            lblSynopsis.Text = Task.Run(async () => await GetAnimeSynopsisAsync()).Result;

            buttons = buttons.OrderBy(a => Guid.NewGuid()).ToList();

            this.frameOption1.Content = buttons[0];
            this.frameOption2.Content = buttons[1];
            this.frameOption3.Content = buttons[2];
            this.frameOption4.Content = buttons[3];


             deviceTimer = new DeviceTimer(StartTimer, TimeSpan.FromSeconds(1), true, true);
           

        }

        private void StartTimer()
        {
            if(timerGuagePointer.Value != 60)
            {
                timerGuagePointer.Value += 1;
            }
            else
            {
                SetUpRound();
            }
        }



        private async Task<string> GetAnimeSynopsisAsync()
        {
            Random random = new Random();
            AnimeById anime = new AnimeById();

            // get an anime save the asnwer and return the synopsis
            try
            {
                anime = await AnimeRepository.GetAnimeAsync(random.Next(1000));
            }
            catch
            {
                // if no anime exist for the random id get one from hard coded
                anime = await AnimeRepository.GetAnimeAsync(random.Next(100,107));
            }
            finally
            {
                // if the synopsis is too short 
                if (anime.Data.Attributes.Synopsis.Length < 100)
                    anime = await AnimeRepository.GetAnimeAsync(random.Next(1,20));

                this.Answer = anime.Data.Attributes.Titles.EnJp;

                // Create a btn with the answer as txt
                this.buttons.Add(createbtn(anime.Data.Attributes.Titles.EnJp, Color.Transparent, Color.Red));
            }

            return anime.Data.Attributes.Synopsis;

        }

        private async Task<List<Button>> SetDummmyOptionsAsync()
        {
            List<Button> buttonsToreturn = new List<Button>();
            AnimeById anime = new AnimeById();
            Random random = new Random();

            // populate options with random Titles
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    // get the anime with the random id
                    anime = await AnimeRepository.GetAnimeAsync(random.Next(1000));
                }
                catch
                {
                    // if no anime exist with generated random int
                    // get the anime with the random id
                    anime = await AnimeRepository.GetAnimeAsync(random.Next(100, 107));

                }
                finally
                {
                    if(options.Contains(anime.Data.Attributes.Titles.EnJp))
                        anime = await AnimeRepository.GetAnimeAsync(random.Next(1, 20));

                    options.Add(anime.Data.Attributes.Titles.EnJp);

                    // Create a btn and add to the button list
                    buttonsToreturn.Add(createbtn(anime.Data.Attributes.Titles.EnJp, Color.Transparent, Color.Red));
                }

            }

            return buttonsToreturn;


        }


        protected void OptionSelected(object sender, EventArgs e)
        {
            string optionSelected = (sender as Button).Text;

            // check if the text of the button clicked is same as asnwer
            if (Answer.Equals(optionSelected))
            {
                (sender as Button).BackgroundColor = Color.SeaGreen;

                Score += 10;
                
                //to clear the timer that is currently going on
                deviceTimer.Stop();

                SetUpRound();
            }
            else
            {
                (sender as Button).BackgroundColor = Color.Red;

                controlLayout.IsVisible = true;

                // call the animation
                ReduceLife();
                this.lifeLeft -= 1;


                if (Score > 0)
                    Score -= 5;

            }


            (sender as Button).TextColor = Color.White;

            // Change Guage 
            guagePointer.Value = Score;

        }


        // Helper Functions
        private Button createbtn(string text, Color backgroundColor, Color textColor)
        {

            Button btn = new Button()
            {
                Text = text,
                BackgroundColor = backgroundColor,
                TextColor = textColor,
            };

            btn.Clicked += new EventHandler(OptionSelected);


            return btn;
        }

        private void ReduceLife()
        {
            // fade out each heart based on life 

            if (this.lifeLeft == 4)
            {
                life4.FadeTo(0, 2000);
            }
            else if (lifeLeft == 3)
            {
                life3.FadeTo(0, 2000);
            }
            else if (lifeLeft == 2)
            {
                life2.FadeTo(0, 2000);
            }
            else if (lifeLeft == 1)
            {
                // last life remove
                life1.FadeTo(0, 2000);
                lblWrong.IsVisible = false;
                btnContinue.IsVisible = false;

                // show the anime meme and game over lbl
                // opm.IsVisible = true;
                lblGameOver.IsVisible = true;

                // show Achived score
                lblFinalScore.Text = $"Your Score : {Score}";
                lblFinalScore.IsVisible = true;
            }
           
        }

      

        private void ContinueGame(object sender, EventArgs e)
        {
            //to clear the timer that is currently going on
            deviceTimer.Stop();
            
            // setup next round
            SetUpRound();

            controlLayout.IsVisible = false;
        }

        private void ResetGame(object sender, EventArgs e)
        {
            // Reset life 
            lifeLeft = 4;
            guagePointer.Value = 0;
            Score = 0;

            // bring back the hear image 
            life1.FadeTo(1, 2000);
            life2.FadeTo(1, 2000);
            life3.FadeTo(1, 2000);
            life4.FadeTo(1, 2000);

            lblFinalScore.IsVisible = false;
            lblGameOver.IsVisible = false;
            controlLayout.IsVisible = false;

            lblWrong.IsVisible = true;
            btnContinue.IsVisible = true;
            
             //to clear the timer that is currently going on
            deviceTimer.Stop();
            SetUpRound();

        }
    }
}
