using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet;

namespace WallBot_Version1._0
{
    public class API
    {
        public string token = "";
        public string user_id = "";
        public API(String Token, String User_id)
        {
            token = Token;
            user_id = User_id;
        }

        private String MethodAPI(String MethodName, String Parametrs)
        {
            using (var req = new HttpRequest())
            {
                return req.Get(String.Format("https://api.vk.com/method/{0}?{1}&{2}", MethodName, Parametrs, token)).ToString();
            }
        }

        public void WallPost(String used_Id, String MessageText)
        {
            MethodAPI("wall.post", String.Format("owner_id={0}&message={1}", used_Id, MessageText));
        }

        public void CommentWallPost(String used_Id, String CommentText, String post_id)
        {
            MethodAPI("wall.createComment", String.Format("owner_id={0}&post_id={1}&message={2}", used_Id, post_id, CommentText));
        }

        public String WallGet()
        {
            return MethodAPI("wall.get.xml", String.Format("owner_id={0}&domain=yarikpavlin&count=100&filter=all", user_id));
        }

        public String GetComments(String used_Id, String post_Id)
        {

            return MethodAPI("wall.getComments.xml", String.Format("owner_id={0}&post_id={1}&need_likes=1", used_Id, post_Id));
        }

        public void DeleteWallPost(String used_Id, String post_Id)
        {
            MethodAPI("wall.delete", String.Format("owner_id={0}&post_id={1}", used_Id, post_Id));
        }
    }
}
