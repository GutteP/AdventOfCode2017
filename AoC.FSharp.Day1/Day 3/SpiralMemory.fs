module SpiralMemory

let rec laps (lap:int) (values:int list)  =
    if Seq.length values < 5+(lap*8) then {| LastLap=values; Laps=lap+1; SideLength=1+(2*lap) |}
    else laps (lap+1) values[4+(lap*8)..]

let side (values: int List) sideLength x =
    let w = values[0..sideLength-1]
    let s = values[sideLength..(sideLength * 2)-1]
    let e = values[sideLength * 2..(sideLength * 3)-1]
    let n = values[sideLength * 3..(sideLength * 4)-1]
    if List.contains x w  then {| Side="w"; Index=(w |> Seq.findIndex (fun n -> n = x) ) |}
    else if List.contains x s then {| Side="s"; Index=(s |> Seq.findIndex (fun n -> n = x) ) |}
    else if List.contains x e then {| Side="e"; Index=(e |> Seq.findIndex (fun n -> n = x) ) |}
    else if List.contains x n then {| Side="n"; Index=(n |> Seq.findIndex (fun n -> n = x) ) |}
    else failwith "Något gick fel"

let absManhattanDistanceA (laps:int) side =
    if side="w" || side="s" then abs laps-1
    else abs laps

let absManhattanDistanceB (laps:int) sideLength side index =
    if side="n" then abs (index - (int (sideLength/2)))
    else if side="s" then abs (index - (int ((sideLength/2)-1)))
    else if side="w" then abs (index - (int ((sideLength/2))))
    else if side="e" then abs (index - (int ((sideLength/2)-1)))
    else failwith "Något gick fel"

let calculateManhattanDistance (laps:int) sideLength side index =
    absManhattanDistanceA laps side + absManhattanDistanceB laps sideLength side index

let part1 (num:int) = 
    let lapsR = laps 0 [1 .. num]
    let sideR = side lapsR.LastLap lapsR.SideLength num
    calculateManhattanDistance lapsR.Laps lapsR.SideLength sideR.Side sideR.Index