
using ProyectoFotoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Repositories
{
    public interface IRepositoryPhoto
    {
        List<PHOTO> GetPhotos(int idSesion);
        void InsertPhoto(String name, int idSesion,String UriAzure);
        void MovePhotosSesion(int idPhoto, int idSesion,String UriAzure);
        void OrderPhotos(int idPhoto, int orderNumber);
        void RemovePhotos(int idPhoto);
        PHOTO GetPhotoById(int idPhoto);

        List<PHOTO_COMPLEX> GetFavorites();
        void SetFavorite(int idPhoto);
        void UndoFavorite(int idPhoto);
        void OrderFavorite(int idPhoto, int orderFavorite);
    }
}
