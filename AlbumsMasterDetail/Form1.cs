using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlbumsMasterDetailDapperModels;



namespace AlbumsMasterDetail
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
