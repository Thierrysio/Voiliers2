using System.Collections.ObjectModel;
using Voiliers2.Modeles;

namespace Voiliers2.Vues;

public partial class VueLocation : ContentPage
{
    public ObservableCollection<Voilier> mesVoiliers { get; set; } 
		= new ObservableCollection<Voilier>();
    public VueLocation()
	{
		InitializeComponent();
        BindingContext = this;

        this.afficherCapacite(new Voilier(5));
		this.afficherVoiliers();

	}
	private void afficherCapacite(Voilier unVoilier)
	{
		nbCapacite.Text = unVoilier.Capacite.ToString();

    }

	private void afficherVoiliers()
	{
		for (int i = 1; i < 6; i++)
		{
			mesVoiliers.Add(new Voilier(i));
		}

	}
}