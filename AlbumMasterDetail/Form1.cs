using AlbumsMasterDetailDapper.Service;
using AlbumsMasterDetailDapperModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumMasterDetail
{
    public partial class Form1 : Form
    {
        private Album _album;
        private IAlbumService _albumService;
        public Form1()
        {
            InitializeComponent();
            _album = new Album();
            _albumService = new AlbumService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSongAdd_Click(object sender, EventArgs e)
        {

            AddSong();
            grdSongs.AutoGenerateColumns = false;
            BindingSource bs = new BindingSource();
            bs.DataSource = _album.Songs;
            grdSongs.DataSource = bs;

            ClearSong();


        }

        private void AddSong()
        {
            Song song = new Song();
            song.Name = txtSongName.Text;
            song.Minutes = txtSongMinutes.Text != string.Empty ? Int32.Parse(txtSongMinutes.Text) : 0;

            if (_album.Songs == null)
                _album.Songs = new List<Song>();

            _album.Songs.Add(song);

        }
        private void ClearSong()
        {
            txtSongName.Text = string.Empty;
            txtSongMinutes.Text = string.Empty;
        }
        private void ClearAlbum()
        {
            txtAlbumName.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtReleaseDate.Value = DateTime.Now;
        }

        private void SaveAlbum()
        {
            _album.Name = txtAlbumName.Text;
            _album.Author = txtAuthor.Text;
            _album.ReleaseDate = txtReleaseDate.Value;
            _albumService.SaveAlbum(_album);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAlbum();
            ClearAlbum();
            grdSongs.DataSource = "";
        }
    }
}
