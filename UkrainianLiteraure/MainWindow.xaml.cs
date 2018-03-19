using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Threading;
namespace UkrainianLiteraure
{

    public partial class MainWindow : Window
    {
        public BaseModel Context = new BaseModel();
        public List<string> BackDirection = new List<string>();
        public void Loading()
        {

            Context.Authors.FirstOrDefault(x => 1 == 1);
        }
        public MainWindow()
        {

            SplashScreen splashScreen = new SplashScreen("bin/Debug/images/icons/ProgramPreview.jpg");
            splashScreen.Show(true);
            Loading();
            InitializeComponent();


        }
        private void ClosePanels()
        {
            MyList.Visibility = Visibility.Hidden;
            AuthorPanel.Visibility = Visibility.Hidden;
            BookPanel.Visibility = Visibility.Hidden;
            ReaderPanel.Visibility = Visibility.Hidden;

            AuthorsName.Text = "";
            AuthorsYears.Text = "";
            AuthorsPeriphrases.Text = "";
            AuthorsDescription.Text = "";
            AuthorsName.Text = "";
            AuthorsBks.Children.Clear();


            BooksHeroes.Text = "";
            BooksPlaces.Text = "";
            BooksDescription.Text = "";
            BooksGenre.Text = "";
            BooksStyle.Text = "";
            BooksTheme.Text = "";
            BooksIdea.Text = "";
            BooksAuthor.Text = "";

            SearchBox.Visibility = Visibility.Hidden;
            TestPanel.Visibility = Visibility.Hidden;

            BackIcon.Visibility = Visibility.Hidden;
            

        }
        public void ShowBookPanel(string NameOfBook)
        {
            ClosePanels();

            BackIcon.Visibility = Visibility.Visible;
            Book ShowedBook = Context.Books.FirstOrDefault(x => x.Name == NameOfBook);
            Read.Tag = ShowedBook.Name;
            BooksName.Text = ShowedBook.Name;
            BooksAuthor.Text = ShowedBook.Author.Fname + " " + ShowedBook.Author.Sname;
            BooksGenre.Inlines.Add(new Bold(new Run("Жанр: ") { Foreground = Brushes.DarkCyan }));
            BooksGenre.Inlines.Add(new Italic(new Run(ShowedBook.Genre)));
            BooksStyle.Inlines.Add(new Bold(new Run("Стиль: ") { Foreground = Brushes.DarkCyan }));
            BooksStyle.Inlines.Add(new Italic(new Run(ShowedBook.Style)));
            BooksTheme.Inlines.Add(new Bold(new Run("Тема: ") { Foreground = Brushes.DarkCyan }));
            BooksTheme.Inlines.Add(new Italic(new Run(ShowedBook.Theme) { FontSize = 12 }));
            BooksIdea.Inlines.Add(new Bold(new Run("Ідея: ") { Foreground = Brushes.DarkCyan }));
            BooksIdea.Inlines.Add(new Italic(new Run(ShowedBook.Idea) { FontSize = 12 }));
            BooksHeroes.Inlines.Add(new Bold(new Run("Герої: \n") { FontSize = 17, Foreground = Brushes.DarkCyan }));
            foreach (Hero h in ShowedBook.Heroes)
            {
                if (h.Description != "")
                {
                    BooksHeroes.Inlines.Add(new Bold(new Run(h.HeroName)));
                    BooksHeroes.Inlines.Add(new Italic(new Run(" - " + h.Description + "\n")));
                }
                else
                    BooksHeroes.Inlines.Add(new Bold(new Run(h.HeroName + "\n")));
            }
            if (BooksHeroes.Text == "Герої: \n")
                BooksHeroes.Text = "";
            if (ShowedBook.PlacesOfActions != "")
            {
                BooksPlaces.Inlines.Add(new Bold(new Run("Місця подій: \n") { FontSize = 12, Foreground = Brushes.DarkCyan }));
                BooksPlaces.Inlines.Add(new Italic(new Run(ShowedBook.PlacesOfActions) { FontSize = 12 }));
            }
            if (ShowedBook.Description != "")
            {
                BooksDescription.Inlines.Add(new Bold(new Run("Додатково: \n") { FontSize = 15, Foreground = Brushes.DarkCyan }));
                BooksDescription.Inlines.Add(new Italic(new Run(ShowedBook.Description) { FontSize = 12 }));
            }
            BookPanel.Visibility = Visibility.Visible;
        }
        public void ShowAuthorPanel(string NameOfAuthor)
        {
            ClosePanels();

            BackIcon.Visibility = Visibility.Visible;
            Author ShowedAuthor = Context.Authors.FirstOrDefault(x => (x.Fname + " " + x.Sname) == NameOfAuthor);

            AuthosPortrait.Source = new BitmapImage(new Uri("pack://application:,,,/bin/Debug/" + ShowedAuthor.Portrait));

            AuthorsName.Text = ShowedAuthor.Fname + " " + ShowedAuthor.Sname;
            AuthorsYears.Text = ShowedAuthor.YearsOfLife;
            foreach (Book b in ShowedAuthor.Books)
            {
                Button but = new Button();
                but.Background = Brushes.Transparent;
                but.Content = b.Name;
                but.Tag = AuthorsName.Text;
                but.BorderThickness = new Thickness(0, 0, 0, 0);
                but.HorizontalContentAlignment = HorizontalAlignment.Left;
                but.Click += Show_Aurhors_Book;
                but.Foreground = Brushes.DarkBlue;
                AuthorsBks.Children.Add(but);

            }
            if (ShowedAuthor.Periphrases.Count != 0)
            {
                AuthorsPeriphrases.Inlines.Add(new Bold(new Run("Перифрази: \n") { FontSize = 15, Foreground = Brushes.DarkCyan }));
                foreach (Periphras p in ShowedAuthor.Periphrases)
                {
                    AuthorsPeriphrases.Inlines.Add(new Italic(new Run(p.PeriphraseName + ";\n") { FontSize = 12 }));
                }
            }

            AuthorsDescription.Text = ShowedAuthor.Description;
            AuthorPanel.Visibility = Visibility.Visible;
        }
        private void ListViewItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            RememberForReturn();
            string books_or_authors_name = ((ListViewItem)(sender)).Tag.ToString();

            if (Context.Authors.Any((x) => (x.Fname + " " + x.Sname) == books_or_authors_name))
            {
                ShowAuthorPanel(books_or_authors_name);
            }
            else
            {
                ShowBookPanel(books_or_authors_name);
            }


        }

        private void Books_Click(object sender, MouseButtonEventArgs e)
        {
            RememberForReturn();
            ClosePanels();
            MyList.Items.Clear();


            foreach (Book b in Context.Books)
            {
                ListViewItem l = new ListViewItem();
                l.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/bin/Debug/images/icons/Book Cover.png")));
                TextBlock tb = new TextBlock();
                tb.Text = b.Name + "\n\n\n" + b.Author.Fname + " " + b.Author.Sname;
                tb.Margin = new Thickness(45, 40, 0, 0);
                tb.Width = 80;
                tb.FontSize = 12;
                tb.Height = 150;
                tb.TextWrapping = TextWrapping.Wrap;
                l.Content = tb;

                l.Tag = b.Name;
                MyList.Items.Add(l);
            }
            MyList.Visibility = Visibility.Visible;

        }

        private void Authors_Click(object sender, MouseButtonEventArgs e)
        {
            RememberForReturn();
            ClosePanels();

            MyList.Items.Clear();
            foreach (Author a in Context.Authors)
            {
                ListViewItem l = new ListViewItem();
                l.Tag = (a.Fname + " " + a.Sname);
                l.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/bin/Debug/" + a.Portrait)));
                MyList.Items.Add(l);
            }

            MyList.Visibility = Visibility.Visible;

        }
        private void Theory_Click(object sender, MouseButtonEventArgs e)
        {

        }
        private void Tests_Click(object sender, MouseButtonEventArgs e)
        {
            TestPanel.Visibility = Visibility.Visible;
            Test t = Context.Tests.First(x => x.Id == 1);
            foreach(Question q in t.Questions)
            {

            }
        }



        private void Read_Click(object sender, RoutedEventArgs e)
        {
            RememberForReturn();
            ClosePanels();

            Book ShowedBook = Context.Books.FirstOrDefault(x => x.Name == BooksName.Text);



            BackIcon.Visibility = Visibility.Visible;

            BookContent.Text = File.ReadAllText(ShowedBook.Path);
            ReaderPanel.Visibility = Visibility.Visible;
        }
        private void Show_Aurhors_Book(object sender, RoutedEventArgs e)
        {

            RememberForReturn();
            ShowBookPanel(((Button)sender).Content.ToString());

        }

        private void Label_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            RememberForReturn();
            ClosePanels();
            MyList.Visibility = Visibility.Visible;
            SearchBox.Visibility = Visibility.Visible;
        }

        private void Tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                MyList.Items.Clear();
               string searched_text = SearchBox.Text;

                List<Author> searched_authors = new List<Author>();
                foreach(Author au in Context.Authors)
                {
                    
                    if ((au.Description!=null && au.Description.Contains(searched_text))|| au.Fname.Contains(searched_text) || au.Sname.Contains(searched_text) || au.YearsOfLife.Contains(searched_text))
                        searched_authors.Add(au);
                    else
                        foreach (Periphras per in au.Periphrases)
                        {
                            if (per.PeriphraseName.Contains(searched_text))
                            {
                                searched_authors.Add(au);
                                break;
                            }
                        }
                }
                foreach (Author a in searched_authors)
                {
                    ListViewItem l = new ListViewItem();
                    l.Tag = (a.Fname + " " + a.Sname);
                    l.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/bin/Debug/" + a.Portrait)));
                    MyList.Items.Add(l);
                }
                List<Book> searched_books = new List<Book>();
                foreach(Book bo in Context.Books)
                {
                     
                    if ((bo.Genre).Contains(searched_text)|| bo.Style.Contains(searched_text) || bo.Name.Contains(searched_text) || (bo.PlacesOfActions!=null && bo.PlacesOfActions.Contains(searched_text)) || (bo.Description!=null && bo.Description.Contains(searched_text)) || bo.Idea.Contains(searched_text) || bo.Theme.Contains(searched_text))
                        searched_books.Add(bo);
                    else
                        foreach( Hero he in bo.Heroes)
                        {
                            if((he.HeroName).Contains(searched_text)|| (he.Description!=null && he.Description.Contains(searched_text)))
                            {
                                searched_books.Add(bo);
                                break;
                            }
                        }
                }
                foreach (Book b in searched_books)
                {
                    ListViewItem l = new ListViewItem();
                    l.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/bin/Debug/images/icons/Book Cover.png")));
                    TextBlock tb = new TextBlock();
                    tb.Text = b.Name + "\n\n\n" + b.Author.Fname + " " + b.Author.Sname;
                    tb.Margin = new Thickness(45, 40, 0, 0);
                    tb.Width = 80;
                    tb.FontSize = 12;
                    tb.Height = 150;
                    tb.TextWrapping = TextWrapping.Wrap;
                    l.Content = tb;

                    l.Tag = b.Name;
                    MyList.Items.Add(l);
                }
                MyList.Visibility = Visibility.Visible;

            }
        }

        private void BackIcon_Click(object sender, RoutedEventArgs e)
        {
            if (BackDirection.Count == 0)
                return;
            string tg = BackDirection.Last();
            if (Context.Authors.Any((x) => (x.Fname + " " + x.Sname) == tg))
            {
                ShowAuthorPanel(tg);

            }
            else
            {
                if (Context.Books.Any((x) => x.Name == tg))
                {
                    ShowBookPanel(tg);

                }
                else
                {
                    if (tg == "list")
                    {
                        ClosePanels();
                        MyList.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (tg == "search")
                        {
                            ClosePanels();
                            MyList.Visibility = Visibility.Visible;
                            SearchBox.Visibility = Visibility.Visible;
                        }
                    }
                    

                        return;
                }
            }
            BackDirection.RemoveAt(BackDirection.Count - 1);
        }
        public void RememberForReturn()
        {
            if (BookPanel.Visibility == Visibility.Visible)
                BackDirection.Add(BooksName.Text);
            else
            {
                if (AuthorPanel.Visibility == Visibility.Visible)
                    BackDirection.Add(AuthorsName.Text);
                else
                {
                    if (MyList.Visibility == Visibility.Visible&& SearchBox.Visibility != Visibility.Visible)
                    {
                        BackDirection.Add("list");
                        if (BackDirection.Contains("search"))
                            BackDirection.Remove("search");
                    }
                    else
                    {
                        if (SearchBox.Visibility == Visibility.Visible)
                        {
                            BackDirection.Add("search");
                        }
                    }
                }
            }
        }
    }
}
