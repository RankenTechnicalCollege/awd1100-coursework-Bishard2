using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public static class BmiCalculator
    {
        public static Bmi CalcBmi(float weightInPounds, float heightInInches)
        {
            if (weightInPounds < 70 || weightInPounds > 300)
                throw new InvalidWeightException();

            if (heightInInches < 60 || heightInInches > 84)
                throw new InvalidHeightException();

            float bmiValue = (weightInPounds / (heightInInches * heightInInches)) * 703;
            WeightCategory category;

            if (bmiValue < 18.5)
                category = WeightCategory.UNDERWEIGHT;
            else if (bmiValue < 25)
                category = WeightCategory.NORMAL;
            else if (bmiValue < 30)
                category = WeightCategory.OVERWEIGHT;
            else
                category = WeightCategory.OBESE;

            return new Bmi(weightInPounds, heightInInches, bmiValue, category);
        }
    }
}
