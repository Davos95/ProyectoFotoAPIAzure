
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
        Task<List<PHOTO>> GetPhotos(int idSesion);
        Task<PHOTO> GetPhotoById(int idPhoto);

        Task InsertPhoto(String name, int idSesion,String UriAzure);

        Task MovePhotosSesion(int idPhoto, int idSesion,String UriAzure);
        Task OrderPhotos(List<Order> orders);
        Task RemovePhotos(int idPhoto);


        Task<List<PHOTO_COMPLEX>> GetFavorites();
        Task SetFavorite(int idPhoto);
        Task UndoFavorite(int idPhoto);
        Task OrderFavorite(List<Order> orders);
    }
}
