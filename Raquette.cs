using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using Raylib_cs;

namespace Breakout;

static partial class Program
{
    /// <summary>Le rectangle occupé par la raquette à l'écran.</summary>
    static Rectangle RectangleRaquette()
    {
        return new Rectangle(positionRaquette.X, positionRaquette.Y, LARGEUR_RAQUETTE, HAUTEUR_RAQUETTE);
    }

    /// <summary>Déplace la raquette avec les flèches, sans sortir de la fenêtre.</summary>
    static void DeplacerRaquette(float dt)
    {
        if (positionRaquette.X > 0 && Raylib.IsKeyDown(KeyboardKey.Left))
        {
            positionRaquette.X -= VITESSE_RAQUETTE * dt;
        }
        else if ((positionRaquette.X + LARGEUR_RAQUETTE) < LARGEUR && Raylib.IsKeyDown(KeyboardKey.Right))
        {
            positionRaquette.X += VITESSE_RAQUETTE * dt;
        }
    }

    /// <summary>Fait rebondir la balle si elle touche la raquette.</summary>
    static void RebondirSurRaquette()
    {
        // vérifier que la balle est à la hauteur de la raquette et que ça touche au minimum à gauche ou maximum à droite
        if (
            (positionBalle.Y + RAYON_BALLE) > positionRaquette.Y && (positionBalle.Y) < positionRaquette.Y      // surface
            && (positionBalle.X + RAYON_BALLE / 2) > (positionRaquette.X - RAYON_BALLE + 1)                     // vérification si dans la zone du rectangle
            && (positionBalle.X + RAYON_BALLE / 2) < (positionRaquette.X + LARGEUR_RAQUETTE + RAYON_BALLE - 1)  // "
            )
        {
            vitesseBalle.Y = -vitesseBalle.Y;
            //positionBalle.Y -= RAYON_BALLE;
        }
    }
}