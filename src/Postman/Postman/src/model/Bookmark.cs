using Postman.src.dll;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.src.model
{
    class Bookmark
    {
        public string name,url,desc,id,group;
        public Dictionary<string, string> parameter;

        public static string addBookmark(string group,string name,string url,string desc,Dictionary<string,string> para)
        {
            string bookmark_id = Guid.NewGuid().ToString();
            StringBuilder statement = new StringBuilder();
            statement.Append(string.Format("insert into bookmark(id,name,url,desc,[group])values('{0}','{1}','{2}','{3}','{4}');", bookmark_id, name, url, desc, group));
            foreach(var item in para)
            {
                string para_id = Guid.NewGuid().ToString();
                statement.Append(string.Format("insert into parameter(id,bookmark_id,key,value)values('{0}','{1}','{2}','{3}');", para_id,bookmark_id, item.Key, item.Value));
            }
            return SQLiteHelper.execute(statement.ToString())>0?bookmark_id:"";
        }

        public static Bookmark getBookmark(string id)
        {
            Bookmark bookmark = null;
            string statement = string.Format("select * from bookmark where id='{0}'",id);
            DataTable bm = SQLiteHelper.select(statement);
            if (bm != null && bm.Rows.Count > 0)
            {
                bookmark = new Bookmark();
                bookmark.id = bm.Rows[0]["id"].ToString();
                bookmark.name = bm.Rows[0]["name"].ToString();
                bookmark.url = bm.Rows[0]["url"].ToString();
                bookmark.desc = bm.Rows[0]["desc"].ToString();
                bookmark.group = bm.Rows[0]["group"].ToString();
                bookmark.parameter = new Dictionary<string, string>();
                statement = string.Format("select * from parameter where bookmark_id='{0}'", id);
                DataTable para = SQLiteHelper.select(statement);
                for(int i = 0; para != null && i < para.Rows.Count; i++)
                {
                    bookmark.parameter.Add(para.Rows[i]["key"].ToString(), para.Rows[i]["value"].ToString());
                }
            }
            return bookmark;

        }

        public static List<Bookmark> getBookmarks()
        {
            List<Bookmark> bookmarks = new List<Bookmark>();
            string statement = string.Format("select id from bookmark");
            DataTable bm = SQLiteHelper.select(statement);
            for (int i=0; bm != null && i<bm.Rows.Count;i++)
            {
                Bookmark bookmark = getBookmark(bm.Rows[i][0].ToString());
                bookmarks.Add(bookmark);
            }
            return bookmarks;
        }

        public int update()
        {
            StringBuilder statement = new StringBuilder();
            statement.Append(string.Format("update bookmark set name='{0}',url='{1}',desc='{2}',[group]='{4}' where id='{3}';", name, url, desc, id, group));
            statement.Append(string.Format("delete from parameter where bookmark_id='{0}';",id));
            foreach (var item in parameter)
            {
                string para_id = Guid.NewGuid().ToString();
                statement.Append(string.Format("insert into parameter(id,bookmark_id,key,value)values('{0}','{1}','{2}','{3}');", para_id, id, item.Key, item.Value));
            }
            return SQLiteHelper.execute(statement.ToString());
        }
        public int delete()
        {
            StringBuilder statement = new StringBuilder();
            statement.Append(string.Format("delete from bookmark where id='{0}';",id));
            statement.Append(string.Format("delete from parameter where bookmark_id='{0}';", id));
            Console.WriteLine(statement);
            return SQLiteHelper.execute(statement.ToString());
        }
        public static int delete(string id)
        {
            StringBuilder statement = new StringBuilder();
            statement.Append(string.Format("delete from bookmark where id='{0}';", id));
            statement.Append(string.Format("delete from parameter where bookmark_id='{0}';", id));
            return SQLiteHelper.execute(statement.ToString());
        }
    }
}
