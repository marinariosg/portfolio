# -----------------------------------------------------------------
# Assignment Name: Employee Pay
# Name: Marina Rios
# -----------------------------------------------------------------

def employee_pay_for(dblStartingPay, dblRaisePercent):

    dblYearlyPay = dblStartingPay * 40 * 52

    for intYear in range(10):

        print("Year", intYear + 1, "-", dblYearlyPay)

        dblYearlyPay = dblYearlyPay + (dblYearlyPay * (dblRaisePercent / 100))

def employee_pay_while(dblStartingPay, dblRaisePercent):

    intYear = 1
    
    dblYearlyPay = dblStartingPay * 40 *52

    while intYear <=10:
        
        print("Year", intYear, "_", dblYearlyPay)

        dblYearlyPay = dblYearlyPay + (dblYearlyPay * (dblRaisePercent/100))

        intYear +=1

employee_pay_for(20,3)
employee_pay_while(20,3)

# I think the for loop is better because it is simpler to read
# I think the for lopp is better because it looks more organized 