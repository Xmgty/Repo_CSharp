using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums;
using VkNet.Enums.Filters;
using VkNet.Exception;
using VkNet.Model;
using VkNet.Model.RequestParams;
using Vk_client.Test;
using System.Net;

namespace Vk_client
{
    public partial class MainForm : Form
    {
        public string str;

        public MainForm()
        {
            InitializeComponent();
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            tbSex.Visible = false;
            tbStatus.Visible = false;
            tbDate.Visible = false;
            tbCity.Visible = false;
            tbCountry.Visible = false;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        VkApi vk = new VkApi();
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = textBox1.Text;
                string pass = textBox2.Text;
                Settings scope = Settings.All;
                ulong appId = 6159996;
                vk.Authorize(new ApiAuthParams
                {
                    ApplicationId = appId,
                    Login = email,
                    Password = pass,
                    Settings = scope
                });
                var setOnline = vk.Account.SetOnline();
                authentication.Parent = null;
                Friends.Visible = true;
            }
            catch (VkApiAuthorizationException)
            {
                LoginError f3 = new LoginError();
                f3.Show();
            }
            var profileInfo = vk.Account.GetProfileInfo();
            nameLabel.Text = profileInfo.FirstName + " " + profileInfo.LastName;

            ProfileFields foto = ProfileFields.Photo100;
            var photos = vk.Users.Get(new long[] { vk.UserId.Value }, foto, null, false);
            
            

            foreach (var avatar in photos)
            {
                pbAvatar.Load(avatar.Photo100.ToString());
                //MessageBox.Show(avatar.Photo2560.ToString());
                //Testing.ResizeImage(Testing.LoadPicture("https://pp.userapi.com/c630221/v630221384/3d9d0/hkCyx1PLP9c.jpg"), pbAvatar, true);
                

                //pbAvatar.Load("https://pp.userapi.com/c630221/v630221384/3d9d0/hkCyx1PLP9c.jpg");
                //pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            ProfileFields pf = ProfileFields.FirstName | ProfileFields.LastName | ProfileFields.Photo100;
            
            var friends = vk.Friends.Get(new FriendsGetParams
            {
                UserId = vk.UserId.Value,
                Fields = pf
                
            });
            foreach (var item in friends)
            {
                FriendsList.Items.Add(item.FirstName + " " + item.LastName);
                
                if (Convert.ToBoolean(item.Online))
                {
                    onlineFriendsList.Items.Add(item.FirstName + " " + item.LastName);
                }
            }

            int friendsCount = friends.Count;
            friendsCnt.Text = "Всего друзей " + Convert.ToString(friendsCount);




            var online = vk.Friends.GetOnline(new FriendsGetOnlineParams
            {
                UserId = vk.UserId.Value
            });

            int friendsOnlineCount = 0;
            foreach (var item in online.Online)
            {
 
                friendsOnlineCount++;
            }
             
            friendsOnlineCnt.Text = Convert.ToString(friendsOnlineCount) + "/" + Convert.ToString(friendsCount);
            var wall = vk.Wall.Get(new WallGetParams
            {
                OwnerId = vk.UserId.Value,
                Count = 30
            });
            /*var msg = vk.Messages.Get(new MessagesGetParams
            {

                Offset = 0,
                Count = 1,
                TimeOffset = 0,
                Filters = MessagesFilter.All



            }).Messages[0];*/
            String status = vk.Status.Get(vk.UserId.Value).Text;
            labelStatus.Text = status;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void allFrinedsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void FriendsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProfileFields pf = ProfileFields.FirstName | ProfileFields.LastName | ProfileFields.Photo100 | ProfileFields.Sex | ProfileFields.Nickname| ProfileFields.BirthDate | ProfileFields.City | ProfileFields.Country;

            var friends = vk.Friends.Get(new FriendsGetParams
            {
                UserId = vk.UserId.Value,
                Fields = pf

            });
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            tbSex.Visible = true;
            tbStatus.Visible = true;
            tbDate.Visible = true;
            tbCity.Visible = true;
            tbCountry.Visible = true;

            pbFriend.Load(friends[FriendsList.SelectedIndex].Photo100.ToString());
            tbSex.Text = friends[FriendsList.SelectedIndex].Sex.ToString();
            if (friends[FriendsList.SelectedIndex].Nickname != null)
                tbStatus.Text = friends[FriendsList.SelectedIndex].FirstName.ToString() + " " + friends[FriendsList.SelectedIndex].LastName.ToString();
            else
                tbStatus.Text = "None";
            if (friends[FriendsList.SelectedIndex].BirthDate != null)
                tbDate.Text = friends[FriendsList.SelectedIndex].BirthDate.ToString();
            else
                tbDate.Text = "Hidden";

            if (friends[FriendsList.SelectedIndex].City != null)
                tbCity.Text = friends[FriendsList.SelectedIndex].City.Title.ToString();
            else
                tbCity.Text = "Hidden";

            if (friends[FriendsList.SelectedIndex].Country != null)
                tbCountry.Text = friends[FriendsList.SelectedIndex].Country.Title.ToString();
            else
                tbCountry.Text = "Hidden";


        }

        
    }
}
