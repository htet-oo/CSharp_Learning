using p2_renshu_2_1.Models;
namespace p2_renshu_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member();
            //using (MemberContext context = new MemberContext())
            //{
            //    member.MemberName = "Htet Oo Wai Yan";
            //    member.MemberTel = "09073609174";

            //    context.Members.Add(member);
            //    context.SaveChanges();
            //}

            using (MemberContext context = new MemberContext())
            {
                Member m = context.Members.First();
                m.MemberName = "Wai Yan";
                context.SaveChanges();
            }

            using (MemberContext context = new MemberContext())
            {
                Member m = context.Members
                                  .OrderBy(m => m.MemberId)
                                  .Last(); 
                context.Members.Remove(m);
                context.SaveChanges();
            }


            using (MemberContext context = new MemberContext())
            {
                foreach (Member m in context.Members)
                {
                    Console.WriteLine($"{m.MemberId} {m.MemberName} {m.MemberTel}");
                }
            }
        }
    }
}
