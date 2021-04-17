using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Kitsu.Anime;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimeNorth.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public string Answer { get; set; }
        public List<Button> buttons = new List<Button>();


        public Home()
        {
            InitializeComponent();
        }

        protected  override void OnAppearing()
        {
            // SetUpRound();
        }

        //private async void SetUpRound()
        //{

        //    // clear the options and answer 
        //    buttons.Clear(); 
        //    Answer = "";

        //    // set options : wrap the awaited task within a task to make it wait
        //    this.buttons = Task.Run(async () => await SetDummmyOptionsAsync()).Result;

        //    // set new synopsis
        //    lblSynopsis.Text = Task.Run(async () => await GetAnimeSynopsisAsync()).Result;

        //    buttons = buttons.OrderBy(a => Guid.NewGuid()).ToList();

        //    this.frameOption1.Content = buttons[0];
        //    this.frameOption2.Content = buttons[1];
        //    this.frameOption3.Content = buttons[2];
        //    this.frameOption4.Content = buttons[3];
        //}



        //private async Task<string> GetAnimeSynopsisAsync()
        //{
        //    // get an anime save the asnwer and return the synopsis
        //    Random random = new Random();
        //    AnimeByIdModel anime = await Anime.GetAnimeAsync(random.Next(1000));
        //    string title = anime.Data.Attributes.Titles.EnJp;
        //    this.Answer = title;

        //    // Create a btn with the answer as txt
        //    this.buttons.Add(createbtn(title, Color.Transparent, Color.Red));


        //    return anime.Data.Attributes.Synopsis;
        //}

        //private async Task<List<Button>> SetDummmyOptionsAsync()
        //{
        //    List<Button> buttonsToreturn = new List<Button>();
        //    string title="";

        //    // populate options with random Titles
        //    for (int i = 0; i < 3; i++)
        //    {
        //        try
        //        {
        //            Random random = new Random();
        //            int rand = random.Next(1000);

        //            // get the anime with the random id
        //            AnimeByIdModel anime = await Anime.GetAnimeAsync(rand);

        //            // get the title of the anime
        //            title = anime.Data.Attributes.Titles.EnJp;
        //        }
        //        catch  
        //        {
        //            // if no anime exist with generated random int
        //            Random random = new Random();
        //            int rand = random.Next(100, 120);

        //            // get the anime with the random id
        //            AnimeByIdModel anime = await Anime.GetAnimeAsync(rand);

        //            // get the title of the anime
        //            title = anime.Data.Attributes.Titles.EnJp;

        //        }
        //        finally
        //        {
        //            // Create a btn and add to the button list
        //            buttonsToreturn.Add(createbtn(title, Color.Transparent, Color.Red));
        //        }

        //    }

        //    return buttonsToreturn;


        //}


        //protected  void OptionSelected(object sender, EventArgs e)
        //{
        //    string s = (sender as Button).Text;

        //    bool result = AnswerChecker(s);

        //    if (result)
        //    {
        //        lblTitle.Text = "Correct";
        //        (sender as Button).BackgroundColor= Color.SeaGreen;


        //    }
        //    else
        //    {
        //        lblTitle.Text = "Wrong";
        //        (sender as Button).BackgroundColor = Color.Red;


        //    }

        //    (sender as Button).TextColor = Color.White;


        //    // setup next round
        //    SetUpRound();


        //}


        //// Helper Functions
        //private Button createbtn(string text, Color backgroundColor, Color textColor)
        //{

        //    Button btn = new Button()
        //    {
        //        Text = text,
        //        BackgroundColor = backgroundColor,
        //        TextColor = textColor,
        //    };

        //    btn.Clicked += new EventHandler(OptionSelected);


        //    return btn;
        //}

        //private bool AnswerChecker(string OptionChoosen)
        //{
        //    if (Answer.Equals(OptionChoosen))
        //        return true;

        //    return false;
        //}


    }
}