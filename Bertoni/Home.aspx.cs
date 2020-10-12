using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using DTO;

namespace Bertoni
{
    public partial class Home : System.Web.UI.Page
    {
        static List<AlbumDTO> ListaAlbum = new List<AlbumDTO>();
        static List<PhotoDTO> ListaPhoto = new List<PhotoDTO>();
        static List<CommentDTO> ListaComment = new List<CommentDTO>();
        protected void Page_Load(object sender, EventArgs e)
        {
            /*AlbumDAO objAlbumDAO = new AlbumDAO();
            ListaAlbum = objAlbumDAO.getDataAlbum();
            *//*
            PhotoDAO objPhotoDAO = new PhotoDAO();
            ListaPhoto = objPhotoDAO.getDataPhoto(3);*/
            if (!this.IsPostBack)
            {
                AlbumDAO objAlbumDAO = new AlbumDAO();
                ListaAlbum = objAlbumDAO.getDataAlbum();
                cmbAlbum.DataSource = ListaAlbum;
                cmbAlbum.DataBind();
            }
        }

        protected void btnVisual_Click(object sender, EventArgs e)
        {
            loadDataGrdPhoto(Convert.ToInt32(cmbAlbum.SelectedValue));
        }
        private void loadDataGrdPhoto(int id)
        {
            PhotoDAO objPhotoDAO = new PhotoDAO();
            ListaPhoto = objPhotoDAO.getDataPhoto(id);
            grdPhoto.DataSource = ListaPhoto; 
            grdPhoto.DataBind(); 
        }

        protected void grdPhoto_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            CommentDAO objCommentDAO = new CommentDAO();
            
            int id = ListaPhoto[Convert.ToInt32(e.CommandArgument)].albumId;
            ListaComment = objCommentDAO.getDataComment(id);
            grdComments.DataSource = ListaComment;
            grdComments.DataBind();
        }
    }
}