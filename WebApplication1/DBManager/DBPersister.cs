using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.DBManager
{
    public class DBPersister
    {
        public int InsertAlbum(AlbumViewModel item)
        {
            string sql = @"
            INSERT INTO [dbo].[Album]
                       ([TitoloAlbum]
                       ,[AnnoUscita]
                       ,[Brano_ID]
                       ,[Band_ID])
                 VALUES
                       (@TitoloAlbum, @AnnoUscita, @Brano_ID, @Band_ID);SELECT @@IDENTITY AS 'Identity';";

            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@TitoloAlbum", item.TitoloAlbum);
            command.Parameters.AddWithValue("@AnnoUscita", item.AnnoUscita);
            command.Parameters.AddWithValue("@Brano_ID", item.Brano_ID);
            command.Parameters.AddWithValue("@Band_ID", item.Band_ID);
            return Convert.ToInt32(command.ExecuteScalar());

        }

        public int InsertArtista(ArtistaViewModel item)
        {
            string sql = @"
            INSERT INTO [dbo].[Artista]
                       ([Nome]
                       ,[Cognome]
                       ,[NomeArte]
                       ,[Tipo])
                 VALUES
                       (@Nome, @Cognome, @NomeArte, @Tipo);SELECT @@IDENTITY AS 'Identity';";

            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Nome", item.Nome);
            command.Parameters.AddWithValue("@Cognome", item.Cognome);
            command.Parameters.AddWithValue("@NomeArte", item.NomeArte);
            command.Parameters.AddWithValue("@Tipo", item.Tipo);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public int InsertBand(BandViewModel item)
        {
            string sql = @"
            INSERT INTO[dbo].[Band]
                       ([Nome]
                       ,[Immagine]
                       ,[Artista_ID])
            VALUES
                  (@Nome, @Immagine, @Artista_ID);SELECT @@IDENTITY AS 'Identity';";
            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Nome", item.Nome);
            command.Parameters.AddWithValue("@Immagine", item.Immagine);
            command.Parameters.AddWithValue("@Artista_ID", item.Artista_ID);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public int InsertBrano(BranoViewModel item)
        {
            string sql = @"
            INSERT INTO[dbo].[Brano]
                   ([TitoloBrano]
                   ,[AnnoUscita]
                   ,[Durata]
                   ,[Genere])
             VALUES
                  (@TitoloBrano, @AnnoUscita, @Durata, @Genere);SELECT @@IDENTITY AS 'Identity';";
            using var connection = new SqlConnection(DBManager.Constants.ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@TitoloBrano", item.TitoloBrano);
            command.Parameters.AddWithValue("@AnnoUscita", item.AnnoUscita);
            command.Parameters.AddWithValue("@Durata", item.Durata);
            command.Parameters.AddWithValue("@Genere", item.Genere);
            return Convert.ToInt32(command.ExecuteScalar());
        }


    }
}

