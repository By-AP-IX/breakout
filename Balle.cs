using System.Numerics;

namespace Breakout;

static partial class Program
{
    /// <summary>Pose la balle au milieu du dessus de la raquette.</summary>
    static void CollerBalleARaquette()
    {
        positionBalle.X = positionRaquette.X + (LARGEUR_RAQUETTE/2);
        positionBalle.Y = (positionRaquette.Y - HAUTEUR_RAQUETTE) + (RAYON_BALLE);
    }

    /// <summary>Donne à la balle sa vitesse de départ.</summary>
    static void LancerBalle()
    {
        vitesseBalle.X = VITESSE_BALLE;
        vitesseBalle.Y = VITESSE_BALLE;
    }

    /// <summary>Avance la balle selon sa vitesse.</summary>
    static void DeplacerBalle(float dt)
    {
        positionBalle.X += vitesseBalle.X * dt;
        positionBalle.Y += vitesseBalle.Y * dt;
    }

    /// <summary>Fait rebondir la balle sur les murs gauche, droit et haut.</summary>
    static void RebondirSurMurs()
    {
        // rebond à gauche
        if (positionBalle.X <= RAYON_BALLE)
        {
            vitesseBalle.X = -vitesseBalle.X;
        }
        // rebond à droite
        if (positionBalle.X >= (LARGEUR - RAYON_BALLE))
        {
            vitesseBalle.X = -vitesseBalle.X;
        }
        // rebond en haut
        if (positionBalle.Y <= RAYON_BALLE)
        {
            vitesseBalle.Y = -vitesseBalle.Y;
        }
    }

    /// <summary>Indique si la balle est entièrement sortie par le bas de la fenêtre.</summary>
    static bool BalleSortieEnBas()
    {
        return false;
    }
}
