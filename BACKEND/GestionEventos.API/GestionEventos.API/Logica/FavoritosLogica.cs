using GestionEventos.API.Datos;
using GestionEventos.API.Modelos.DTOs;

namespace GestionEventos.API.Logica
{
    public class FavoritosLogica
    {
        private readonly FavoritosDAO _favoritosDAO;
        public FavoritosLogica(IConfiguration configuration)
        {
            var cadena = configuration.GetConnectionString("SqlConnection") ?? "";
            _favoritosDAO = new FavoritosDAO(cadena);
        }

        public bool AgregarFavoritoEvento(int usuarioId, int eventoId)
        {
            return _favoritosDAO.AgregarFavoritoEvento(usuarioId, eventoId);
        }

        public bool AgregarFavoritoCompetencia(int usuarioId, int competenciaId)
        {
            return _favoritosDAO.AgregarFavoritoCompetencia(usuarioId, competenciaId);
        }

        public bool EliminarFavoritoEvento(int usuarioId, int eventoId)
        {
            return _favoritosDAO.EliminarFavoritoEvento(usuarioId, eventoId);
        }

        public bool EliminarFavoritoCompetencia(int usuarioId, int competenciaId)
        {
            return _favoritosDAO.EliminarFavoritoCompetencia(usuarioId, competenciaId);
        }

        public FavoritosDTO ListarPorUsuario(int usuarioId)
        {
            return _favoritosDAO.ListarPorUsuario(usuarioId);
        }
    }
}