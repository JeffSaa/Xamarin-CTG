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
using Android.Support.V7.Widget;

namespace PostsDemo.Droid
{
    class PostAdapter : RecyclerView.Adapter
    {
        public List<Post> posts;

        public PostAdapter(List<Post> _posts)
        {
            posts = _posts;
        }

        public override RecyclerView.ViewHolder
            OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).
                        Inflate(Resource.Layout.post_layout, parent, false);

            PostViewHolder vh = new PostViewHolder(itemView);
            return vh;
        }

        public override void
            OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            PostViewHolder vh = holder as PostViewHolder;
            vh.Title.Text = posts[position].title;
            vh.Body.Text = posts[position].body;
        }

        public override int ItemCount
        {
            get { return posts.Count; }
        }

    }


    class PostViewHolder : RecyclerView.ViewHolder
    {

        public TextView Title { get; private set; }
        public TextView Body { get; private set; }

        public PostViewHolder(View itemView)
            : base(itemView)
        {
            Title = itemView.FindViewById<TextView>(Resource.Id.title_txt);
            Body = itemView.FindViewById<TextView>(Resource.Id.body_txt);
        }
    }

}