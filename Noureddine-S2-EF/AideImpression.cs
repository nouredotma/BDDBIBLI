using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Noureddine_S2_EF
{
    public static class AideImpression
    {
        public static void OuvrirGrandApercu(PrintPreviewDialog apercu)
        {
            Form fenetre = (Form)apercu;
            fenetre.WindowState = FormWindowState.Maximized;
            apercu.ShowDialog();
        }

        public static void DessinerTableLocations(Graphics g, DataTable dt, ref int ligne,
            string titreDocument, PrintPageEventArgs e)
        {
            Font policeTitre = new Font("Arial", 14, FontStyle.Bold);
            Font policeEntete = new Font("Arial", 10, FontStyle.Bold);
            Font policeCellule = new Font("Arial", 10, FontStyle.Regular);
            Pen pen = new Pen(Color.Black, 1);

            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int hauteurLigne = 26;
            int largeurTable = 620;

            int[] colX = { x, x + 55, x + 125, x + 215, x + 315, x + 415, x + largeurTable };

            if (ligne == 0)
            {
                g.DrawString(titreDocument, policeTitre, Brushes.Black, x, y);
                y = y + 35;
            }

            int debutTable = y;

            // Ligne du haut + en-têtes
            g.DrawLine(pen, x, y, x + largeurTable, y);
            g.DrawString("Id", policeEntete, Brushes.Black, colX[0] + 3, y + 5);
            g.DrawString("Id livre", policeEntete, Brushes.Black, colX[1] + 3, y + 5);
            g.DrawString("Id adh.", policeEntete, Brushes.Black, colX[2] + 3, y + 5);
            g.DrawString("Date loc.", policeEntete, Brushes.Black, colX[3] + 3, y + 5);
            g.DrawString("Date ret.", policeEntete, Brushes.Black, colX[4] + 3, y + 5);
            g.DrawString("Statut", policeEntete, Brushes.Black, colX[5] + 3, y + 5);
            y = y + hauteurLigne;
            g.DrawLine(pen, x, y, x + largeurTable, y);

            while (ligne < dt.Rows.Count && y + hauteurLigne <= e.MarginBounds.Bottom)
            {
                string dateRetour = "";
                if (dt.Rows[ligne][4] != null && dt.Rows[ligne][4] != System.DBNull.Value)
                    dateRetour = System.Convert.ToDateTime(dt.Rows[ligne][4]).ToShortDateString();

                g.DrawString(dt.Rows[ligne][0].ToString(), policeCellule, Brushes.Black, colX[0] + 3, y + 5);
                g.DrawString(dt.Rows[ligne][1].ToString(), policeCellule, Brushes.Black, colX[1] + 3, y + 5);
                g.DrawString(dt.Rows[ligne][2].ToString(), policeCellule, Brushes.Black, colX[2] + 3, y + 5);
                g.DrawString(System.Convert.ToDateTime(dt.Rows[ligne][3]).ToShortDateString(), policeCellule, Brushes.Black, colX[3] + 3, y + 5);
                g.DrawString(dateRetour, policeCellule, Brushes.Black, colX[4] + 3, y + 5);
                g.DrawString(dt.Rows[ligne][5].ToString(), policeCellule, Brushes.Black, colX[5] + 3, y + 5);

                y = y + hauteurLigne;
                g.DrawLine(pen, x, y, x + largeurTable, y);
                ligne++;
            }

            // Lignes verticales
            for (int c = 0; c < colX.Length; c++)
            {
                g.DrawLine(pen, colX[c], debutTable, colX[c], y);
            }

            e.HasMorePages = ligne < dt.Rows.Count;
        }
    }
}
