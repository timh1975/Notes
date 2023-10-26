using Notes.DataBase;

namespace Notes.Views;

public partial class NotePage : ContentPage
{
	Db database;
	
	public NotePage()
	{
        InitializeComponent();
    }

	/// <summary>
	/// Save new note to database
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public async void SaveNote_Clicked(object sender, EventArgs e)
	{
		string note = TextEditor.Text;
		string comment_note = txtComment.Text;
		DateTime noteDate = DateTime.Now;


		NoteTable n = new NoteTable();
		n.note = note;
		n.Date = noteDate;

		Comments comments = new Comments();
		comments.Comment = comment_note;

        int fk = await Db.AddComment(comments);
		n.Comment_Id = fk;
        await Db.AddNote(n);
		
		
	}

	public async void DeleteNote_Clicked(object sender, EventArgs e)
	{
		
	}

}