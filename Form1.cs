using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Section3CC
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		System.Collections.ArrayList ActorArrayList = new System.Collections.ArrayList();
		

		private void frmMain_Load( object sender, EventArgs e )
		{

		}


		public void LoadArrayList()
		{
			string[] lines = System.IO.File.ReadAllLines( @"C:\\Users\Rose\SkyDrive\Visual Studio 2015\Projects\Section3CC\actors.txt" );

			foreach( string Actor in lines )
			{
				ActorArrayList.Add( Actor );
			}
		}


		void WriteArrayList()
		{
			var path = @"C:\\Users\Rose\SkyDrive\Visual Studio 2015\Projects\Section3CC\actors.txt";
			
			var streamWriter = File.CreateText( path );
			foreach( object Actor in ActorArrayList )
			{
				streamWriter.WriteLine(Actor.ToString());
			}
			streamWriter.Close();
		}




		void PopulateActors()
		{
			cboActor.Items.Clear();
			foreach( object Actor in ActorArrayList )
			{
				cboActor.Items.Add( Actor );
			}
			
		}




		void InsertIntoArrayList(string ArrayItem, int ArrayIndex)
		{

			ActorArrayList.Insert( ArrayIndex, ArrayItem );
		}





		void DeleteFromArrayList(int ArrayIndex)
		{
			ActorArrayList.RemoveAt( ArrayIndex );
		}
		



		private void mnuRead_Click( object sender, EventArgs e )
		{
			LoadArrayList();
			PopulateActors();
		}




		private void openFileDialog1_FileOk( object sender, CancelEventArgs e )
		{
			LoadArrayList();
			PopulateActors();
		}





		private void btnInsert_Click( object sender, EventArgs e )
		{
			if (txtPosition.Text != null && txtActorName.Text != null)
				try
				 {
					InsertIntoArrayList( txtActorName.Text, int.Parse(txtPosition.Text) );
					PopulateActors();
				}
				catch (Exception ex)
				{
					MessageBox.Show( "Please enter valid position and name. Check to see that you have loaded the file before attempting to amend to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
				}
				
		}





		private void btnDelete_Click( object sender, EventArgs e )
		{
			if( txtPosition.Text != null )
				try
				{
					DeleteFromArrayList( int.Parse( txtPosition.Text ) );
					PopulateActors();
				}
				catch ( Exception ex )
				{
					MessageBox.Show( "Please enter a position and ensure you have loaded the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop );					;
				}
		}





		private void mnuWrite_Click( object sender, EventArgs e )
		{
			WriteArrayList();
		}





		private void saveFileDialog1_FileOk( object sender, CancelEventArgs e )
		{
			WriteArrayList();
		}





		private void mnuExit_Click( object sender, EventArgs e )
		{
			Environment.Exit(0);
		}




	}
}
