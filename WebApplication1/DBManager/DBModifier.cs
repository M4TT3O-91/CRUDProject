using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.DBManager
{
    public class DBModifier
    {
        public int UpdateAlbum(AlbumViewModel item)
        {
            string sql = @" UPDATE Album 
                           SET [TitoloAlbum] = @TitoloAlbum
                                ,[AnnoUscita] = @AnnoUscita
                                ,[Brano_ID] = @Brano_ID
                                ,[Band_ID] = Band_ID
                            WHERE IdAlbum = @IdAlbum";

            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@TitoloAlbum", item.TitoloAlbum);
            command.Parameters.AddWithValue("@AnnoUscita", item.AnnoUscita);
            command.Parameters.AddWithValue("@Brano_ID", item.Brano_ID);
            command.Parameters.AddWithValue("@Band_ID", item.Band_ID);
            command.Parameters.AddWithValue("@IdAlbum", item.IdAlbum);
            return command.ExecuteNonQuery();
        }

        public int UpdateArtista(ArtistaViewModel item)
        {
            string sql = @"UPDATE Album
                            SET [Nome] = @Nome
                                ,[Cognome] = @Cognome
                                ,[NomeArte] = @NomeArte
                                ,[Tipo] = @Tipo
                            WHERE IdArtista = @IdArtista";

            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Nome", item.Nome);
            command.Parameters.AddWithValue("@Cognome", item.Cognome);
            command.Parameters.AddWithValue("@NomeArte", item.NomeArte);
            command.Parameters.AddWithValue("@Tipo", item.Tipo);
            command.Parameters.AddWithValue("@IdArtista", item.IdArtista);
            return command.ExecuteNonQuery();
        }

        public int UpdateBand(BandViewModel item)
        {
            string sql = @" UPDATE  Band
                            SET [Nome] = @Nome
                               ,[Immagine] = @Immagine
                               ,[Artista_ID] = @ArtistaID
                            WHERE IdBand = @IdBand";
            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Nome", item.Nome);
            command.Parameters.AddWithValue("@Immagine", item.Immagine);
            command.Parameters.AddWithValue("@Artista_ID", item.Artista_ID);
            command.Parameters.AddWithValue("@IdBand", item.IdBand);
            return command.ExecuteNonQuery();
        }

        public int UpdateBrano(BranoViewModel item)
        {
            string sql = @"UPDATE Brano 
                            SET [TitoloBrano] = @TitoloBrano
                               ,[AnnoUscita] = @AnnoUscita
                               ,[Durata] = @Durata
                               ,[Genere] = @Genere
                         WHERE IdBrano = @IdBrano";
            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@TitoloBrano", item.TitoloBrano);
            command.Parameters.AddWithValue("@AnnoUscita", item.AnnoUscita);
            command.Parameters.AddWithValue("@Durata", item.Durata);
            command.Parameters.AddWithValue("@Genere", item.Genere);
            command.Parameters.AddWithValue("@IdBrano", item.IdBrano);
            return command.ExecuteNonQuery();
        }


    }
}

