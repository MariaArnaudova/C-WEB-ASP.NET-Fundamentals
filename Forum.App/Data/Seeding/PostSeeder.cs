
namespace Forum.App.Data.Seeding
{
    using Models;
    internal class PostSeeder
    {
        internal Post[] GeneratePosts()
        {
            ICollection<Post> posts = new HashSet<Post>();
            Post currentPost;

            currentPost = new Post()
            {
                Title = "My first post",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam scelerisque vulputate nibh, quis euismod diam consequat in. Nullam at nulla. ",

            };

            posts.Add(currentPost);

            currentPost = new Post()
            {
                Title  = "My second post",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris commodo elit id erat fringilla luctus. "
            };
            posts.Add(currentPost);

            currentPost = new Post()
            {
                Title = "My third post",
                Content = "Consectetur adipiscing elit. Mauris commodo elit id erat fringilla luctus. "
            };
            posts.Add(currentPost);

            return posts.ToArray();   
        }
    }
}
