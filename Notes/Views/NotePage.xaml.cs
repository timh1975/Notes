using Notes.DataBase;

namespace Notes.Views;

public partial class NotePage : ContentPage
{
	db database;
	
	public NotePage()
	{
        InitializeComponent();
    }

	public async void SaveButton_Clicked(object sender, EventArgs e)
	{
		string note = TextEditor.Text;
		DateTime noteDate = DateTime.Now;

		Note n = new Note();
		n.note = note;
		n.Date = noteDate;

     	await db.AddNote(n);
		
	}

	public async void DeleteButton_Clicked(object sender, EventArgs e)
	{

	}

}