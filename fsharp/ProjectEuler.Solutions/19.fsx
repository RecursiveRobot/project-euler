type DayOfWeek =
    | Monday = 1
    | Tuesday = 2
    | Wednesday = 3
    | Thursday = 4
    | Friday = 5
    | Saturday = 6
    | Sunday = 7

type Date =
    {
        Year : int
        Month : int
        Day : int
        DayOfWeek : DayOfWeek
    }
    static member isALeapYear = function
            | y when y % 4 > 1 -> false
            | y when y % 4 = 0 && (y % 100 > 0 || y % 400 = 0) -> true
            | _ -> false
            
    static member numberOfDaysInMonth month year =
        let monthsWith30Days = [4;6;9;11]
        let monthsWith31Days = [1;3;5;7;8;10;12]

        if List.exists (fun a -> a = month) monthsWith30Days then
            30
        else if List.exists (fun a -> a = month) monthsWith31Days then
            31
        else if month = 2 && Date.isALeapYear year then
            29
        else
            28

    static member getNextDayOfWeek (currentDayOfWeek : DayOfWeek) =
            if currentDayOfWeek = DayOfWeek.Sunday then
                DayOfWeek.Monday
            else
                enum<DayOfWeek>((int)currentDayOfWeek + 1)

    static member AllDaysFrom startYear startYearFirstDayOfWeek : Date seq = 
        let getNextDate currentDate =
            match (currentDate.Day, currentDate.Month, currentDate.Year) with
            | (d,m,y) when d = (Date.numberOfDaysInMonth m y) && m = 12 -> {currentDate with Day = 1; Month = 1; Year = y+1; DayOfWeek = Date.getNextDayOfWeek currentDate.DayOfWeek}
            | (d,m,y) when d = (Date.numberOfDaysInMonth m y) -> {currentDate with Day = 1; Month = m+1; Year = y; DayOfWeek = Date.getNextDayOfWeek currentDate.DayOfWeek}
            | (d,m,y) when d < (Date.numberOfDaysInMonth m y) -> {currentDate with Day = d+1; DayOfWeek = Date.getNextDayOfWeek currentDate.DayOfWeek}

        let rec AllDaysFromImpl currentDate = seq {
                yield currentDate
                yield! AllDaysFromImpl (getNextDate currentDate)
        }
        
        let startDate = {
            Year = startYear
            Month = 1
            Day = 1
            DayOfWeek = startYearFirstDayOfWeek
        }

        AllDaysFromImpl startDate

let answer =
    Date.AllDaysFrom 1900 DayOfWeek.Monday
    |> Seq.skipWhile (fun a -> a.Year < 1901)
    |> Seq.filter (fun a -> a.Day = 1 && a.DayOfWeek = DayOfWeek.Sunday)
    |> Seq.takeWhile (fun a -> a.Year < 2001)
    |> Seq.length