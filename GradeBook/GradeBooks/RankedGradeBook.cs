using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
  public class RankedGradeBook : BaseGradeBook
  {
    public RankedGradeBook(string name): base (name)
    {
      Type = Enums.GradeBookType.Ranked;
    }

    public override char GetLetterGrade(double averageGrade)
    {
      if (averageGrade >= 80)
      {
        throw new InvalidOperationException();
      }

      if(averageGrade >= 0 && averageGrade < 20)
      {
        return 'A';
      }

      if(averageGrade >= 20 && averageGrade < 40)
      {
        return 'B';
      }

      if (averageGrade >= 40 && averageGrade < 60)
      {
        return 'C';
      }

      if (averageGrade >= 60 && averageGrade < 80)
      {
        return 'D';
      }
      return 'F';
    }
  }
}
