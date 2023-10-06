using Notes.DataBase;

namespace Notes.Views;

public partial class NotePage : ContentPage
{
	db database;
	
	public NotePage()
	{
        InitializeComponent();
    }

	/// <summary>
	/// Save new note to database
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public async void SaveButton_Clicked(object sender, EventArgs e)
	{
		string note = TextEditor.Text;
		DateTime noteDate = DateTime.Now;

		NoteTable n = new NoteTable();
		n.note = note;
		n.Date = noteDate;

     	await db.AddNote(n);
		
	}

	public async void DeleteButton_Clicked(object sender, EventArgs e)
	{

	}

}