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

        public BranoViewModel GetBranoByID(int id)
        {
            BranoViewModel brano = new BranoViewModel();
            string sql = @"Select * from Brano where IdBrano= @id";

            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                brano.IdBrano = Convert.ToInt32(reader["IdBrano"].ToString());
                brano.TitoloBrano = reader["TitoloBrano"].ToString();
                brano.AnnoUscita = DateTime.Parse(reader["AnnoUscita"].ToString());
                brano.Durata = Decimal.Parse(reader["Durata"].ToString());
                brano.Genere = reader["Genere"].ToString();
            }
            return brano;
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

        public ArtistaViewModel GetArtistaByID(int id)
        {
            ArtistaViewModel artista = new ArtistaViewModel();
            string sql = @"Select * from Artista where IdArtista = @Id";
            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            command.Parameters.AddWithValue("@Id", id);
            while (reader.Read())
            {
                artista.IdArtista = Convert.ToInt32(reader["IdArtista"].ToString());
                artista.Nome = reader["Nome"].ToString();
                artista.Cognome = reader["Cognome"].ToString();
                artista.NomeArte = reader["NomeArte"].ToString();
                artista.Tipo = reader["Tipo"].ToString();
            }
            return artista;
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

        public AlbumViewModel GetAlbumByID(int id)
        {
            AlbumViewModel album = new AlbumViewModel();
            string sql = @"Select * from Album where IdAlbum = @Id";
            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", id);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                album.IdAlbum = Convert.ToInt32(reader["IdAlbum"].ToString());
                album.Band_ID = Convert.ToInt32(reader["Band_ID"].ToString());
                album.Brano_ID = Convert.ToInt32(reader["Brano_ID"].ToString());
                album.TitoloAlbum = reader["TitoloAlbum"].ToString();
                album.AnnoUscita = DateTime.Parse(reader["AnnoUScita"].ToString());
            }
            return album;
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
            
        }

        public BandViewModel GetBandByID(int id)
        {
            BandViewModel band = new BandViewModel();
            string sql = @"Select * from Album where IdBand = @Id";
            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            command.Parameters.AddWithValue("@Id", id);
            while (reader.Read())
            {
                band.IdBand = Convert.ToInt32(reader["IdBand"].ToString());
                band.Artista_ID = Convert.ToInt32(reader["Artista_ID"].ToString());
                band.Immagine = reader["Immagine"].ToString();
                band.Nome = reader["Nome"].ToString();
                
            }
            return band;

        }









    }
}
