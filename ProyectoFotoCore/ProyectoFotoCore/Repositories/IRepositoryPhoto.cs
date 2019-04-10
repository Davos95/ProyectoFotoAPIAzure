
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

        Task InsertPhoto(String name, int idSesion,String UriAzure, String token);

        Task MovePhotosSesion(int idPhoto, int idSesion,String UriAzure, String token);
        Task OrderPhotos(List<Order> orders, String token);
        Task RemovePhotos(int idPhoto, String token);


        Task<List<PHOTO_COMPLEX>> GetFavorites();
        Task SetFavorite(int idPhoto, String token);
        Task UndoFavorite(int idPhoto, String token);
        Task OrderFavorite(List<Order> orders, String token);
    }
}
