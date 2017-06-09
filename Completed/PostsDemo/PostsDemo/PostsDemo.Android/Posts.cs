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
using PostsDemo;
using Android.Support.V7.Widget;

namespace PostsDemo.Droid
{
    [Activity(Label = "Posts")]
    public class Posts : Activity
    {
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        PostAdapter mAdapter;
        List<Post> posts;

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.posts);
            string name = Intent.GetStringExtra("UserName") ?? "Sin nombre";
            Toast.MakeText(this, "Hi, " + name, ToastLength.Short).Show();
            posts = await Service.GetPost();
            recyclerInit();
        }

        private void recyclerInit()
        {
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);
            mAdapter = new PostAdapter(posts);
            mRecyclerView.SetAdapter(mAdapter);
        }

    }
}