using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Controlador;

namespace Democratic
{
    /// <summary>
    /// Paleta y helpers centralizados para modo claro/oscuro en WinForms.
    /// </summary>
    public static class UiTheme
    {
        public static readonly Color AzulMarca = ColorTranslator.FromHtml("#324E7E");
        public static readonly Color FondoOscuro = ColorTranslator.FromHtml("#0c0715");
        public static readonly Color FondoPanel = ColorTranslator.FromHtml("#211f2e");
        public static readonly Color FondoMedio = ColorTranslator.FromHtml("#454356");
        public static readonly Color FondoSidebar = ColorTranslator.FromHtml("#282638");
        public static readonly Color FondoMorado = ColorTranslator.FromHtml("#161422");
        public static readonly Color FondoMenu = ColorTranslator.FromHtml("#272244");
        public static readonly Color SidebarHover = ColorTranslator.FromHtml("#282638");
        public static readonly Color InputLogin = ColorTranslator.FromHtml("#4d768d");
        public static readonly Color InputLogin2 = ColorTranslator.FromHtml("#4b918d");
        public static readonly Color InputLogin3 = ColorTranslator.FromHtml("#759e9b");
        public static readonly Color GrisPanel = ColorTranslator.FromHtml("#3b3f48");
        public static readonly Color BtnPrimary = ColorTranslator.FromHtml("#4e79a2");
        public static readonly Color BtnDanger = ColorTranslator.FromHtml("#BF5E6F");
        public static readonly Color GridHeader = ColorTranslator.FromHtml("#BF5E6F");
        public static readonly Color AcentoCyan = Color.Cyan;
        public static readonly Color TextoClaro = Color.White;

        public static bool IsDarkMode => VarSession.Color == 1;

        public static Color ToolbarColor => IsDarkMode ? FondoOscuro : AzulMarca;

        public static void ApplyToolbar(ToolStrip toolStrip)
        {
            if (toolStrip != null)
            {
                toolStrip.BackColor = ToolbarColor;
            }
        }

        public static void ApplyToolbar(params ToolStrip[] toolStrips)
        {
            foreach (ToolStrip toolStrip in toolStrips)
            {
                ApplyToolbar(toolStrip);
            }
        }

        public static void ApplyMenuStrip(MenuStrip menuStrip)
        {
            if (!IsDarkMode || menuStrip == null)
            {
                return;
            }

            menuStrip.BackColor = FondoOscuro;
        }

        public static void ApplyControlsLight(params Control[] controls)
        {
            if (!IsDarkMode)
            {
                return;
            }

            foreach (Control control in controls)
            {
                if (control != null)
                {
                    control.ForeColor = TextoClaro;
                }
            }
        }

        public static void ApplyMinimizarLight(ToolStripButton btn)
        {
            if (IsDarkMode && btn != null)
            {
                btn.ForeColor = TextoClaro;
            }
        }

        public static void ApplyCrudPanel(Panel panel, ToolStrip toolbar, Control[] labels,
            Button btnAdd, Button btnUpdate, Button btnClear, ToolStripButton btnMinimizar, Button btnDelete = null)
        {
            if (!IsDarkMode)
            {
                return;
            }

            if (panel != null)
            {
                panel.BackColor = FondoMorado;
            }

            ApplyToolbar(toolbar);
            ApplyControlsLight(labels);
            ApplyMinimizarLight(btnMinimizar);

            if (btnAdd != null)
            {
                btnAdd.BackColor = BtnPrimary;
            }

            if (btnUpdate != null)
            {
                btnUpdate.BackColor = BtnPrimary;
            }

            if (btnClear != null)
            {
                btnClear.BackColor = BtnPrimary;
            }

            if (btnDelete != null)
            {
                btnDelete.BackColor = BtnDanger;
            }
        }

        public static void ApplyBunifuGrid(BunifuCustomDataGrid grid)
        {
            if (!IsDarkMode || grid == null)
            {
                return;
            }

            grid.BackgroundColor = FondoMedio;
            grid.HeaderBgColor = GridHeader;
            grid.HeaderForeColor = TextoClaro;
        }

        public static void FormatGridCell(DataGridViewCellFormattingEventArgs e, BunifuCustomDataGrid grid)
        {
            if (!IsDarkMode)
            {
                return;
            }

            e.CellStyle.ForeColor = TextoClaro;
            e.CellStyle.BackColor = FondoPanel;
            e.CellStyle.SelectionBackColor = AcentoCyan;
            e.CellStyle.SelectionForeColor = Color.Black;
            ApplyBunifuGrid(grid);
        }

        public static void ApplySidebarButton(BunifuFlatButton btn, bool submenu)
        {
            if (!IsDarkMode || btn == null)
            {
                return;
            }

            Color normal = submenu ? FondoMedio : FondoOscuro;
            btn.Normalcolor = normal;
            btn.OnHovercolor = SidebarHover;
            btn.BackColor = normal;
        }

        public static void ApplyContenedor(Panel panelSidebar, Panel panelUser,
            MenuStrip menuStrip, ToolStrip toolStrip1, ToolStrip toolStrip2,
            BunifuFlatButton[] primaryButtons, BunifuFlatButton[] secondaryButtons)
        {
            if (!IsDarkMode)
            {
                return;
            }

            foreach (BunifuFlatButton btn in primaryButtons)
            {
                ApplySidebarButton(btn, false);
            }

            foreach (BunifuFlatButton btn in secondaryButtons)
            {
                ApplySidebarButton(btn, true);
            }

            if (panelSidebar != null)
            {
                panelSidebar.BackColor = FondoSidebar;
            }

            if (panelUser != null)
            {
                panelUser.BackColor = FondoSidebar;
            }

            ApplyMenuStrip(menuStrip);
            ApplyToolbar(toolStrip1);

            if (toolStrip1 != null)
            {
                toolStrip1.BackColor = FondoMenu;
            }

            if (toolStrip2 != null)
            {
                toolStrip2.BackColor = FondoMenu;
            }
        }

        public static void ApplyLogin(ToolStrip toolbar, Panel panel,
            TextBox txtUser, TextBox txtPass, TextBox txtDui, TextBox txtOcr)
        {
            ApplyToolbar(toolbar);

            if (!IsDarkMode)
            {
                return;
            }

            if (panel != null)
            {
                panel.BackgroundImage = null;
                panel.BackColor = FondoOscuro;
            }

            if (txtUser != null)
            {
                txtUser.BackColor = InputLogin;
            }

            if (txtPass != null)
            {
                txtPass.BackColor = InputLogin2;
            }

            if (txtDui != null)
            {
                txtDui.BackColor = InputLogin;
            }

            if (txtOcr != null)
            {
                txtOcr.BackColor = InputLogin;
            }
        }

        public static void ApplySetupForm(ToolStrip toolbar, Panel panel, params Control[] labels)
        {
            ApplySetupForm(toolbar, panel, null, null, null, labels);
        }

        public static void ApplySetupForm(ToolStrip toolbar, Panel panel,
            TextBox txtUser, TextBox txtPass, TextBox txtPassConfirm, params Control[] labels)
        {
            ApplyToolbar(toolbar);

            if (!IsDarkMode)
            {
                return;
            }

            if (panel != null)
            {
                panel.BackgroundImage = null;
                panel.BackColor = FondoOscuro;
            }

            ApplyControlsLight(labels);

            if (txtUser != null)
            {
                txtUser.BackColor = InputLogin;
            }

            if (txtPass != null)
            {
                txtPass.BackColor = InputLogin2;
            }

            if (txtPassConfirm != null)
            {
                txtPassConfirm.BackColor = InputLogin3;
            }
        }

        public static void ApplyGrayPanel(Panel panel, ToolStrip toolbar, ToolStripButton btnMinimizar = null)
        {
            if (!IsDarkMode)
            {
                return;
            }

            if (panel != null)
            {
                panel.BackColor = GrisPanel;
            }

            ApplyToolbar(toolbar);
            ApplyMinimizarLight(btnMinimizar);
        }

        public static void ApplyCharts(Panel panel, Control groupBox, params Control[] charts)
        {
            if (!IsDarkMode)
            {
                return;
            }

            if (panel != null)
            {
                panel.BackColor = GrisPanel;
            }

            if (groupBox != null)
            {
                groupBox.BackColor = GrisPanel;
                groupBox.ForeColor = TextoClaro;
            }

            foreach (Control chart in charts)
            {
                if (chart != null)
                {
                    chart.BackColor = GrisPanel;
                }
            }
        }
    }
}
