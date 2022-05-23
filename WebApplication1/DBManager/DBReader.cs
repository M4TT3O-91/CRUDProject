using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.DBManager
{
    public class DBReader
    {
        public IEnumerable<BranoViewModel> GetAllBrani()
        {
            string sql = @"Select * from Brano";

            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                yield return new BranoViewModel
                {
                    IdBrano = Convert.ToInt32(reader["IdBrano"].ToString()),
                    TitoloBrano = reader["TitoloBrano"].ToString(),
                    AnnoUscita = DateTime.Parse(reader["AnnoUscita"].ToString()),
                    Durata = Decimal.Parse(reader["Durata"].ToString()),
                    Genere = reader["Genere"].ToString(),
                };

            }
        }

        public IEnumerable<ArtistaViewModel> GetAllArtista()
        {
            string sql = @"Select * from Artista";
            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                yield return new ArtistaViewModel
                {
                    IdArtista = Convert.ToInt32(reader["IdArtista"].ToString()),
                    Nome = reader["Nome"].ToString(),
                    Cognome = reader["Cognome"].ToString(),
                    NomeArte = reader["NomeArte"].ToString(),
                    Tipo = reader["Tipo"].ToString(),
                };
            }
        }

        public IEnumerable<AlbumViewModel> GetAllAlbum()
        {
            string sql = @"Select * from Album";
            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                yield return new AlbumViewModel
                {
                    IdAlbum = Convert.ToInt32(reader["IdAlbum"].ToString()),
                    Band_ID = Convert.ToInt32(reader["Band_ID"].ToString()),
                    Brano_ID = Convert.ToInt32(reader["Brano_ID"].ToString()),
                    TitoloAlbum = reader["TitoloAlbum"].ToString(),
                    AnnoUscita = DateTime.Parse(reader["AnnoUScita"].ToString()),
                };
            }
        }

        public IEnumerable<BandViewModel> GetAllBand()
        {
            string sql = @"Select * from Album";
            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                yield return new BandViewModel
                {
                    IdBand = Convert.ToInt32(reader["IdBand"].ToString()),
                    Artista_ID = Convert.ToInt32(reader["Artista_ID"].ToString()),
                    Immagine = reader["Immagine"].ToString(),
                    Nome = reader["Nome"].ToString(),
                };
            }
            /*------------- Query JOIN -------------*/
        }










    }
}
