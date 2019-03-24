using System.Windows;
using System.Data.Entity;

namespace WpfSQLiteExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.Levels.Load();
            this.DataContext = db.Levels.Local.ToBindingList();
        }
        // добавление
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            LevelWindow levelWindow = new LevelWindow(new Level());
            if (levelWindow.ShowDialog() == true)
            {
                Level level = levelWindow.Level;
                db.Levels.Add(level);
                db.SaveChanges();
            }
        }
        // редактирование
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (levelsList.SelectedItem == null) return;
            // получаем выделенный объект
            Level level = levelsList.SelectedItem as Level;

            LevelWindow levelWindow = new LevelWindow(new Level
            {
                Id = level.Id,
                Uri = level.Uri,
                Title = level.Title
            });

            if (levelWindow.ShowDialog() == true)
            {
                // получаем измененный объект
                level = db.Levels.Find(levelWindow.Level.Id);
                if (level != null)
                {
                    level.Uri = levelWindow.Level.Uri;
                    level.Title = levelWindow.Level.Title;
                    db.Entry(level).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        // удаление
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (levelsList.SelectedItem == null) return;
            // получаем выделенный объект
            Level level = levelsList.SelectedItem as Level;
            db.Levels.Remove(level);
            db.SaveChanges();
        }
    }
}
