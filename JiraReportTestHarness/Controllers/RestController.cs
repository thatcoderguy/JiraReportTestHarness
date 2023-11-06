using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace JiraReportTestHarness.Controllers
{
    [Route("rest/api/2")]
    [ApiController]
    public class RestController : ControllerBase
    {
        [HttpGet("search")]
        public ActionResult<Results> Search(string jql, int maxResults, int startAt)
        {

            //([\w\d\"\)\(\-]*)([ ~ | != | = | !~ | > | >= | < | <= | IS | IS NOT | WAS | WAS IN | WAS NOT | WAS NOT IN | CHANGED | OR | AND | IN | NOT IN ])?
            //(.*?)(>=|<=|~|!=|=|!~|>|<| IS | IS NOT | WAS | WAS IN | WAS NOT | WAS NOT IN | CHANGED | OR | AND | IN | NOT IN )
            //((.*?)(>=|<=|~|!=|=|!~|>|<| IS | IS NOT | WAS | WAS IN | WAS NOT | WAS NOT IN | CHANGED | OR | AND | IN | NOT IN ))|(.*?)$
            //(.*?)((>=|<=|~|!=|=|!~|>|<| IS | IS NOT | WAS | WAS IN | WAS NOT | WAS NOT IN | CHANGED IN | NOT IN )|( OR | AND )|($))
            //(((?!AND |OR |or |and ).*?)(>=|<=|~|!=|=|!~|>|<| IS | IS NOT | WAS | WAS IN | WAS NOT | WAS NOT IN | CHANGED IN | NOT IN| IN )(?!AND |OR |or |and ).*?)\s|(AND |and |OR |or )

            Regex blah = new Regex("(?:(AND |OR |and |or )\\s+)?(\\S+?)\\s*([<>!]?=|!?~|[<>]|IN)\\s*(\\S+)");

            if (blah.IsMatch(jql))
            {
                MatchCollection matches = blah.Matches(jql);
            }

            return new Results();
        }


        
        [HttpGet("project")]
        public ActionResult<Project> GetProject()
        {
            return new Project();
        }


        [HttpGet( "field")]
        public ActionResult<Field> GetField()
        {
            return new Field();
        }

        [HttpGet( "issuetype")]
        public ActionResult<IssueType> GetIssueType()
        {
            return new IssueType();
        }

    }
}
