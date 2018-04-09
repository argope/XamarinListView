using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    public class Adapter : BaseAdapter<car>
    {
        public List<car> listOfCars;
        Activity context;

        public Adapter(Activity context, List<car> cars) : base()
        {
            this.context = context;
            this.listOfCars = cars;
        }

        public override long GetItemId(int position)
        {
            return position;
        }


        public override int Count
        {
            get { return listOfCars.Count; }
        }

        public override car this[int position]
        {
            get { return listOfCars[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            var car = listOfCars[position];
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.listViewItem, null);
            }
            view.FindViewById<ImageView>(Resource.Id.imageView1).SetImageResource(car.picture);
            view.FindViewById<TextView>(Resource.Id.make).Text = car.make;
            view.FindViewById<TextView>(Resource.Id.model).Text = car.model;
            view.FindViewById<TextView>(Resource.Id.kw).Text = car.kw;
            return view;
        }
    }
}