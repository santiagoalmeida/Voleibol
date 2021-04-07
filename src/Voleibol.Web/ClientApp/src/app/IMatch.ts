interface IMatch {
  team1: string;
  team2: string;
  times: ITimes[];
  pointTeam: number;
  finish: boolean;
  winner: string;
}

interface ITimes {
  numTime: number;
  team1Points: number;
  team2Points: number;
  terminado: boolean;
}
