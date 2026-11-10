# -----------------------------------------------------------------
# Project Name: Project 1 Employee Discount Program
# Name: Marina Rios
# -----------------------------------------------------------------



# -----------------------------------------------------------------
# Project 1 Function Area
# -----------------------------------------------------------------



# -----------------------------------------------------------------
# Function Name: Validate Integer Input
# Function Purpose: Validate integer data
# -----------------------------------------------------------------
def Validate_Integer_Input(int_Input):

    try:

        int_Input = int(int_Input)
        if int_Input > 0:
            return int_Input
        else:
            print("Value Must Be Positive")
            return 0
    except ValueError:
            print("Value Must Be Numeric")
            return 0



# -----------------------------------------------------------------
# Function Name: Validate Double Input
# Function Purpose: Validate decimal data
# -----------------------------------------------------------------
def Validate_Double_Input(dbl_Input):

    try:
        dbl_Input = float(dbl_Input)
        if dbl_Input >=0:
            return dbl_Input
        else: 
            print("Value Cannot Be Negative")

        return -1
    except ValueError:
        print("Value Must Be Numeric")
    return -1



# -----------------------------------------------------------------
# Function Name: Calc Discount Percent
# Function Purpose: Determine employee discount percentage
# -----------------------------------------------------------------
def Calc_Discount_Percent(intYearsWorked, strEmployeeType):

    if strEmployeeType == "M":

       if intYearsWorked <=3:
        dblDiscountPercent = .20

       else:

         if  intYearsWorked <=6:
            dblDiscountPercent = .24

         else:

          if intYearsWorked <= 10:
             dblDiscountPercent = .30

          else:
            
             if intYearsWorked <= 15:
                dblDiscountPercent = .35

             else:

               dblDiscountPercent = .40

    else:

       if intYearsWorked <=3:
          dblDiscountPercent = .10

       else:

          if intYearsWorked <=6:
             dblDiscountPercent = .14

          else:

             if intYearsWorked <=10:
                dblDiscountPercent = .20

             else:

                if intYearsWorked <=15:
                   dblDiscountPercent = .25

                else:
                   dblDiscountPercent = .30

    return dblDiscountPercent



# -----------------------------------------------------------------
# Function Name: Calc YTD Discount
# Function Purpose: Calculate YTD discount amount
# -----------------------------------------------------------------
def Calc_YTD_Discount(dblPreviousPurchases, dblDiscountPercent):

    dblYTDDiscount = dblPreviousPurchases * dblDiscountPercent
    return dblYTDDiscount



# -----------------------------------------------------------------
# Function Name: Calc Current Discount
# Function Purpose: Calculate current purchase discount
# -----------------------------------------------------------------
def Calc_Current_Discount(dblTodayPurchase, dblDiscountPercent, dblYTDDiscount):

    dblCurrentDiscount = dblTodayPurchase * dblDiscountPercent

    if dblYTDDiscount >= 200:
        dblCurrentDiscount = 0

    elif (dblYTDDiscount + dblCurrentDiscount) > 200:
            dblCurrentDiscount = 200 - dblYTDDiscount

    return dblCurrentDiscount


  
# -----------------------------------------------------------------
# Function Name: Calc Total With Discount
# Function Purpose: Calculate total purchase after discount
# ----------------------------------------------------------
def Calc_Total_With_Discount(dblTodayPurchase, dblCurrentDiscount):

    dblTotalWithDiscount = dblTodayPurchase - dblCurrentDiscount

    return dblTotalWithDiscount



# -----------------------------------------------------------------
# Function Name: Display Employee Results
# Function Purpose: Display employee discount information
# -----------------------------------------------------------------
def Display_Employee_Results(dblDiscountPercent, dblYTDDiscount, dblTodayPurchase, dblCurrentDiscount, dblTotalWithDiscount):

    print()

    print("Employee Discount Percentage:", format(dblDiscountPercent * 100, ".0f"), "%")
    print("YTD Amount of Discount: $", format(dblYTDDiscount, ".2f"))
    print("Total Purchase Today Before Discount: $",format(dblTodayPurchase, ".2f"))
    print("Employee Discount This Purchase: $", format(dblCurrentDiscount, ".2f"))
    print("Total With Discount: $", format(dblTotalWithDiscount, ".2f"))

    print()

    return



# -----------------------------------------------------------------
# Function Name: Display Daily Totals
# Function Purpose: Display all employee summary
# -----------------------------------------------------------------
def Display_Daily_Totals(dblTotalBeforeDiscount, dblTotalAfterDiscount):

    print()

    print("All Employee Summary")
    print("Total Before Discount For Day: $", format(dblTotalBeforeDiscount, ".2f"))
    print("Total After Discounts Applied: $",format(dblTotalAfterDiscount, ".2f"))

    print()

    return



# -----------------------------------------------------------------
# Project 1 Main Processing Area
# -----------------------------------------------------------------
dblTotalBeforeDiscount = float(0)
dblTotalAfterDiscount = float(0)

strAnotherEmployee = str("Y")
while strAnotherEmployee.upper() == "Y":

    # get years worked
    intYearsWorked = int(0)
    while intYearsWorked <=0:
        intYearsWorked = input("Enter Number Of Years Worked:")
        intYearsWorked = Validate_Integer_Input(intYearsWorked)

        # get previous purchase
    dblPreviousPurchases = float(-1)
    while dblPreviousPurchases < 0:
          dblPreviousPurchases = input("Enter Previous Purchases Amount:")
          dblPreviousPurchases = Validate_Double_Input(dblPreviousPurchases)

          # get employee type
    strEmployeeType = input("Employee Type (M=Manager, H=Hourly):").upper()

    # get today's purchase
    dblTodayPurchase = float(-1)
    while dblTodayPurchase< 0:
              dblTodayPurchase = input("Enter Today's Purchase Amount:")
              dblTodayPurchase = Validate_Double_Input(dblTodayPurchase)

              # perform calculations
    dblDiscountPercent = Calc_Discount_Percent(intYearsWorked, strEmployeeType)
    dblYTDDiscount = Calc_YTD_Discount(dblPreviousPurchases, dblDiscountPercent)
    dblCurrentDiscount = Calc_Current_Discount(dblTodayPurchase, dblDiscountPercent, dblYTDDiscount)
    dblTotalWithDiscount = Calc_Total_With_Discount(dblTodayPurchase,dblCurrentDiscount)

    # display results
    Display_Employee_Results( dblDiscountPercent, dblYTDDiscount, dblTodayPurchase, dblCurrentDiscount, dblTotalWithDiscount)

    # accumulate totals
    dblTotalBeforeDiscount += dblTodayPurchase
    dblTotalAfterDiscount += dblTotalWithDiscount

    # another employee
    strAnotherEmployee = str(input("Another Employee (Y/N)?"))

# display daily totals
Display_Daily_Totals(dblTotalBeforeDiscount, dblTotalAfterDiscount)
         




