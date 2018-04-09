using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace App1
{
    [Activity(Label = "Cars", MainLauncher = true)]
    public class HomeScreen : ListActivity
    {
        private List<car> cars = new List<car>();
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ListView listView = FindViewById<ListView>(Resource.Id.listView);


            cars.Add(new car() { picture = Resource.Drawable.subaru, make = "Subaru", model = "Impreza 22b STi" , kw="206 KW"});
            cars.Add(new car() { picture = Resource.Drawable.gtr33, make = "Nissan", model = "Skyline R33 GT-R" , kw="206 KW"});
            cars.Add(new car() { picture = Resource.Drawable.rx7, make = "Mazda", model = "RX-7" , kw="195 KW"});
            cars.Add(new car() { picture = Resource.Drawable.gt86, make = "Toyota", model = "Corolla AE86" , kw="84 KW"});
            cars.Add(new car() { picture = Resource.Drawable.evo5, make = "Mitsubishi", model = "Lancer Evolution V" , kw="206 KW"});
            cars.Add(new car() { picture = Resource.Drawable.supra, make = "Toyota", model = "Supra MK2" , kw="103 KW"});
            cars.Add(new car() { picture = Resource.Drawable.nsx, make = "Honda", model = "NSX" , kw="216 KW"});
            cars.Add(new car() { picture = Resource.Drawable.mx5, make = "Mazda", model = "mx5" , kw="86 KW"});
            cars.Add(new car() { picture = Resource.Drawable.civic, mak[e = "Honda", model = "Civic Type R" , kw="86 KW"});
            cars.Add(new car() { picture = Resource.Drawable.n350z, make = "Nissan", model = "350z" , kw="257 KW"});

            ListAdapter = new Adapter(this, cars);
        }
    }
}

