using Raylib_cs;

namespace Breakout;

static partial class Program
{
    /// <summary>Le rectangle occupé à l'écran par la brique (ligne, colonne).</summary>
    static Rectangle RectangleBrique(int ligne, int colonne)
    {
        return new Rectangle();
    }

    /// <summary>Casse la brique touchée par la balle, fait rebondir la balle et ajoute les points.</summary>
    static void CasserBriques()
    {
    }

    /// <summary>Le nombre de briques encore présentes.</summary>
    static int CompterBriques()
    {
        return 0;
    }

    /// <summary>Dessine les briques encore présentes, une couleur par ligne.</summary>
    static void DessinerBriques()
    {
        for (int i = 1; i <= LIGNES_BRIQUES; i++)
        {
            // 1 = rectangles rouges, 2 = rectangles oranges, 3 = rectangles jaunes
            for (int j = 1; j <= COLONNES_BRIQUES; j++)
            {
                // créer rectangles       
            }
        }
    }
}