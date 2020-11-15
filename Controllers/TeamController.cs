using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        [HttpGet("[action]")]
        public IEnumerable<Team> teamPlayers() {
            return  this.getTeams();
        }

        public List<Team> getTeams() {
            List<Team> teams = new List<Team>
            {
                new Team{ Id=1, team="Team1", city="General Santos", coach="Francis Paterno", winslosses="5-0",conference="America East Conference", division="NCAA Division I",
                    fivestartplayers = new List<string>{ "Vonifaida Laluna - Center", "Bonimae Laluna - Power Forward", "Adia Laluna - Small Forward", "Bonifacio Laluna - Point Guard", "Gloreme Erfe - Shooting Guard"} },
                new Team{ Id=2, team="Team2", city="General Santos", coach="Francis Paterno", winslosses="5-0",conference="American Athletic Conference", division="NCAA Division I",
                    fivestartplayers = new List<string>{ "Vonifaida Laluna - Center", "Bonimae Laluna - Power Forward", "Adia Laluna - Small Forward", "Bonifacio Laluna - Point Guard", "Gloreme Erfe - Shooting Guard"} },
                new Team{ Id=3, team="Team3", city="General Santos", coach="Francis Paterno", winslosses="5-0",conference="Atlantic 10 Conference", division="NCAA Division I",
                    fivestartplayers = new List<string>{ "Vonifaida Laluna - Center", "Bonimae Laluna - Power Forward", "Adia Laluna - Small Forward", "Bonifacio Laluna - Point Guard", "Gloreme Erfe - Shooting Guard"} },
                new Team{ Id=4, team="Team4", city="General Santos", coach="Francis Paterno", winslosses="5-0",conference="Atlantic Coast Conference", division="NCAA Division I",
                    fivestartplayers = new List<string>{ "Vonifaida Laluna - Center", "Bonimae Laluna - Power Forward", "Adia Laluna - Small Forward", "Bonifacio Laluna - Point Guard", "Gloreme Erfe - Shooting Guard"} },
                new Team{ Id=5, team="Team5", city="General Santos", coach="Francis Paterno", winslosses="5-0",conference="Atlantic Sun Conference", division="NCAA Division I",
                    fivestartplayers = new List<string>{ "Vonifaida Laluna - Center", "Bonimae Laluna - Power Forward", "Adia Laluna - Small Forward", "Bonifacio Laluna - Point Guard", "Gloreme Erfe - Shooting Guard"} },
                new Team{ Id=6, team="Team6", city="General Santos", coach="Francis Paterno", winslosses="5-0",conference="Big 12 Conference", division="NCAA Division I",
                    fivestartplayers = new List<string>{ "Vonifaida Laluna - Center", "Bonimae Laluna - Power Forward", "Adia Laluna - Small Forward", "Bonifacio Laluna - Point Guard", "Gloreme Erfe - Shooting Guard"} },
                new Team{ Id=7, team="Team7", city="General Santos", coach="Francis Paterno", winslosses="5-0",conference="Big East Conference", division="NCAA Division I",
                    fivestartplayers = new List<string>{ "Vonifaida Laluna - Center", "Bonimae Laluna - Power Forward", "Adia Laluna - Small Forward", "Bonifacio Laluna - Point Guard", "Gloreme Erfe - Shooting Guard"} },
                new Team{ Id=8, team="Team8", city="General Santos", coach="Francis Paterno", winslosses="5-0",conference="Big Sky Conference", division="NCAA Division I",
                    fivestartplayers = new List<string>{ "Vonifaida Laluna - Center", "Bonimae Laluna - Power Forward", "Adia Laluna - Small Forward", "Bonifacio Laluna - Point Guard", "Gloreme Erfe - Shooting Guard"} },
                new Team{ Id=9, team="Team9", city="General Santos", coach="Francis Paterno", winslosses="5-0",conference="Big South Conference", division="NCAA Division I",
                    fivestartplayers = new List<string>{ "Vonifaida Laluna - Center", "Bonimae Laluna - Power Forward", "Adia Laluna - Small Forward", "Bonifacio Laluna - Point Guard", "Gloreme Erfe - Shooting Guard"} },
                new Team{ Id=10, team="Team10", city="General Santos", coach="Francis Paterno", winslosses="5-0",conference="Big Ten Conference", division="NCAA Division I",
                    fivestartplayers = new List<string>{ "Vonifaida Laluna - Center", "Bonimae Laluna - Power Forward", "Adia Laluna - Small Forward", "Bonifacio Laluna - Point Guard", "Gloreme Erfe - Shooting Guard"} },

                new Team{ Id=11,team="Team11", city="Koronadal City", coach="Roberto Paterno", winslosses="4-1",conference="California Collegiate Athletic Association", division="NCAA Division II",
                    fivestartplayers = new List<string>{ "Theresa Paterno - Center", "Joeseph Paterno - Power Forward", "Catherine Paterno - Small Forward", "Leonardo Paterno - Point Guard", "Florable Paterno - Shooting Guard"} },
                new Team{ Id=12,team="Team12", city="Koronadal City", coach="Roberto Paterno", winslosses="4-1",conference="Central Atlantic Collegiate Conference", division="NCAA Division II",
                    fivestartplayers = new List<string>{ "Theresa Paterno - Center", "Joeseph Paterno - Power Forward", "Catherine Paterno - Small Forward", "Leonardo Paterno - Point Guard", "Florable Paterno - Shooting Guard"} },
                new Team{ Id=13,team="Team13", city="Koronadal City", coach="Roberto Paterno", winslosses="4-1",conference="Central Intercollegiate Athletic Association", division="NCAA Division II",
                    fivestartplayers = new List<string>{ "Theresa Paterno - Center", "Joeseph Paterno - Power Forward", "Catherine Paterno - Small Forward", "Leonardo Paterno - Point Guard", "Florable Paterno - Shooting Guard"} },
                new Team{ Id=14,team="Team14", city="Koronadal City", coach="Roberto Paterno", winslosses="4-1",conference="Conference Carolinas", division="NCAA Division II",
                    fivestartplayers = new List<string>{ "Theresa Paterno - Center", "Joeseph Paterno - Power Forward", "Catherine Paterno - Small Forward", "Leonardo Paterno - Point Guard", "Florable Paterno - Shooting Guard"} },
                new Team{ Id=15,team="Team15", city="Koronadal City", coach="Roberto Paterno", winslosses="4-1",conference="East Coast Conference", division="NCAA Division II",
                    fivestartplayers = new List<string>{ "Theresa Paterno - Center", "Joeseph Paterno - Power Forward", "Catherine Paterno - Small Forward", "Leonardo Paterno - Point Guard", "Florable Paterno - Shooting Guard"} },
                new Team{ Id=16,team="Team16", city="Koronadal City", coach="Roberto Paterno", winslosses="4-1",conference="Great American Conference", division="NCAA Division II",
                    fivestartplayers = new List<string>{ "Theresa Paterno - Center", "Joeseph Paterno - Power Forward", "Catherine Paterno - Small Forward", "Leonardo Paterno - Point Guard", "Florable Paterno - Shooting Guard"} },
                new Team{ Id=17,team="Team17", city="Koronadal City", coach="Roberto Paterno", winslosses="4-1",conference="Great Lakes Intercollegiate Athletic Conference", division="NCAA Division II",
                    fivestartplayers = new List<string>{ "Theresa Paterno - Center", "Joeseph Paterno - Power Forward", "Catherine Paterno - Small Forward", "Leonardo Paterno - Point Guard", "Florable Paterno - Shooting Guard"} },
                new Team{ Id=18,team="Team18", city="Koronadal City", coach="Roberto Paterno", winslosses="4-1",conference="Great Lakes Valley Conference", division="NCAA Division II",
                    fivestartplayers = new List<string>{ "Theresa Paterno - Center", "Joeseph Paterno - Power Forward", "Catherine Paterno - Small Forward", "Leonardo Paterno - Point Guard", "Florable Paterno - Shooting Guard"} },
                new Team{ Id=19,team="Team19", city="Koronadal City", coach="Roberto Paterno", winslosses="4-1",conference="Great Midwest Athletic Conference", division="NCAA Division II",
                    fivestartplayers = new List<string>{ "Theresa Paterno - Center", "Joeseph Paterno - Power Forward", "Catherine Paterno - Small Forward", "Leonardo Paterno - Point Guard", "Florable Paterno - Shooting Guard"} },
                new Team{ Id=20,team="Team20", city="Koronadal City", coach="Roberto Paterno", winslosses="4-1",conference="Great Northwest Athletic Conference", division="NCAA Division II",
                    fivestartplayers = new List<string>{ "Theresa Paterno - Center", "Joeseph Paterno - Power Forward", "Catherine Paterno - Small Forward", "Leonardo Paterno - Point Guard", "Florable Paterno - Shooting Guard"} },

                new Team{ Id=21,team="Team21", city="Municipality of Norala", coach="Nenita Lanicia", winslosses="1-5", conference="Allegheny Mountain Collegiate Conference", division="NCAA Division III",
                    fivestartplayers = new List<string>{ "Cheryl Lanicia - Center", "Ann Lanicia - Power Forward", "Carlos Lanicia - Small Forward", "Romeo Lacro - Point Guard", "Nida Lacro - Shooting Guard"} },
                new Team{ Id=22,team="Team22", city="Municipality of Norala", coach="Nenita Lanicia", winslosses="1-5", conference="American Rivers Conference", division="NCAA Division III",
                    fivestartplayers = new List<string>{ "Cheryl Lanicia - Center", "Ann Lanicia - Power Forward", "Carlos Lanicia - Small Forward", "Romeo Lacro - Point Guard", "Nida Lacro - Shooting Guard"} },
                new Team{ Id=23,team="Team23", city="Municipality of Norala", coach="Nenita Lanicia", winslosses="1-5", conference="American Southwest Conference", division="NCAA Division III",
                    fivestartplayers = new List<string>{ "Cheryl Lanicia - Center", "Ann Lanicia - Power Forward", "Carlos Lanicia - Small Forward", "Romeo Lacro - Point Guard", "Nida Lacro - Shooting Guard"} },
                new Team{ Id=24,team="Team24", city="Municipality of Norala", coach="Nenita Lanicia", winslosses="1-5", conference="Atlantic East Conference", division="NCAA Division III",
                    fivestartplayers = new List<string>{ "Cheryl Lanicia - Center", "Ann Lanicia - Power Forward", "Carlos Lanicia - Small Forward", "Romeo Lacro - Point Guard", "Nida Lacro - Shooting Guard"} },
                new Team{ Id=25,team="Team25", city="Municipality of Norala", coach="Nenita Lanicia", winslosses="1-5", conference="Capital Athletic Conference", division="NCAA Division III",
                    fivestartplayers = new List<string>{ "Cheryl Lanicia - Center", "Ann Lanicia - Power Forward", "Carlos Lanicia - Small Forward", "Romeo Lacro - Point Guard", "Nida Lacro - Shooting Guard"} },
                new Team{ Id=26,team="Team26", city="Municipality of Norala", coach="Nenita Lanicia", winslosses="1-5", conference="Centennial Conference", division="NCAA Division III",
                    fivestartplayers = new List<string>{ "Cheryl Lanicia - Center", "Ann Lanicia - Power Forward", "Carlos Lanicia - Small Forward", "Romeo Lacro - Point Guard", "Nida Lacro - Shooting Guard"} },
                new Team{ Id=27,team="Team27", city="Municipality of Norala", coach="Nenita Lanicia", winslosses="1-5", conference="City University of New York Athletic Conference", division="NCAA Division III",
                    fivestartplayers = new List<string>{ "Cheryl Lanicia - Center", "Ann Lanicia - Power Forward", "Carlos Lanicia - Small Forward", "Romeo Lacro - Point Guard", "Nida Lacro - Shooting Guard"} },
                new Team{ Id=28,team="Team28", city="Municipality of Norala", coach="Nenita Lanicia", winslosses="1-5", conference="College Conference of Illinois and Wisconsin", division="NCAA Division III",
                    fivestartplayers = new List<string>{ "Cheryl Lanicia - Center", "Ann Lanicia - Power Forward", "Carlos Lanicia - Small Forward", "Romeo Lacro - Point Guard", "Nida Lacro - Shooting Guard"} },
                new Team{ Id=29,team="Team29", city="Municipality of Norala", coach="Nenita Lanicia", winslosses="1-5", conference="Colonial States Athletic Conference", division="NCAA Division III",
                    fivestartplayers = new List<string>{ "Cheryl Lanicia - Center", "Ann Lanicia - Power Forward", "Carlos Lanicia - Small Forward", "Romeo Lacro - Point Guard", "Nida Lacro - Shooting Guard"} },
                new Team{ Id=30,team="Team30", city="Municipality of Norala", coach="Nenita Lanicia", winslosses="1-5", conference="Commonwealth Coast Conference", division="NCAA Division III",
                    fivestartplayers = new List<string>{ "Cheryl Lanicia - Center", "Ann Lanicia - Power Forward", "Carlos Lanicia - Small Forward", "Romeo Lacro - Point Guard", "Nida Lacro - Shooting Guard"} },

            };

            return teams;
        }
    }
}
