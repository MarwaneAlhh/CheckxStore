package checkxstore;

import java.io.File;
import java.sql.*;

public class Dbo {

    private String serverName = "VIPER17\\SQL17";
    private String databaseName = "wkforce_live";

    public Dbo() {

        String connectionString = "jdbc:sqlserver://" + serverName
                + ";databaseName=" + databaseName
                + ";integratedSecurity=true;"
                + "encrypt=false;"
                + "trustServerCertificate=true";

        Connection connection = null;

        try {
            String pathToDll = System.getProperty("user.dir") + "/libs/sqljdbc_auth.dll";
            File dllFile = new File(pathToDll);
            
            if (dllFile.exists()) {
                System.out.println("Le fichier sqljdbc_auth.dll existe : " + pathToDll);
            } else {
                System.out.println("Le fichier sqljdbc_auth.dll n'existe pas à l'emplacement spécifié : " + pathToDll);
            }
            System.setProperty("java.library.path", pathToDll);
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver"); // Chargement du pilote JDBC
            connection = DriverManager.getConnection(connectionString);
            System.out.println("Connexion réussie !");
        } catch (ClassNotFoundException e) {
            System.out.println("Pilote JDBC non trouvé : " + e.getMessage());
        } catch (SQLException e) {
            System.out.println("Erreur lors de la connexion : " + e.getMessage());
        } finally {
            // Assurez-vous de fermer la connexion lorsque vous avez terminé
            if (connection != null) {
                try {
                    connection.close();
                } catch (SQLException e) {
                    System.out.println("Erreur lors de la fermeture de la connexion : " + e.getMessage());
                }
            }
        }
    }
}
