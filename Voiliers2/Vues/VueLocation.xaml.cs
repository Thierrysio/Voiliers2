using Voiliers2.Modeles;

namespace Voiliers2.Vues;

public partial class VueLocation : ContentPage
{
	public VueLocation()
	{
		InitializeComponent();
		this.afficherCapacite(new Voilier(5));

	}
	private void afficherCapacite(Voilier unVoilier)
	{
		nbCapacite.Text = unVoilier.Capacite.ToString();

    }
}