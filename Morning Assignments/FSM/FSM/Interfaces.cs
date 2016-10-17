using System;


interface IStates
{
  Enum sName { get; set; }
  Delegate dDel { get; set; }
  bool Handler();
}
