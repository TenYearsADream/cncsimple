﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CncConvProg.ViewModel.MainViewModel
{
    public class DummyMainPageViewModel : IMainViewModel
    {
        private static string _progText;
        static public string ProgText
        {
            get
            {
                return @"N1
T0303G0G98
M5
M69
M45
G0G28H0
G1X35Y-35
G1Z-2
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-2
G1Z-4
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-4
G1Z-6
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-6
G1Z-8
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-8
G1Z-10
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-10
G1Z-12
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-12
G1Z-14
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-14
G1Z-16
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-16
G1Z-18
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-18
G1Z-20
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-20
G1Z-22
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-22
G1Z-24
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-24
G1Z-26
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-26
G1Z-28
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-28
G1Z-30
G1X29Y-29
X29Y39
X-5,36251888138838
G4R34,009X-38,9238716975666Y7,40570607957618
G1X-38,9987781311311Y5,77120688928113
X-39,0061437445766Y-29
X29Y-29
X21Y31
X-5,26251367272951Y31
G4R26,007X-30,9414174176917Y6,83963157716579
G1X-30,9988169421147Y5,58714268231129
X-31,0044489184865Y-21
X21Y-21
X13Y23
X-5,16250846407065Y23
G4R18,004X-22,9589631378169Y6,27355707475541
G1X-22,9988557530984Y5,40307847534145
X-23,0027540923964Y-13
X13Y-13
X5Y15
X-5,06250325541179
G4R10,002X-14,976508857942Y5,70748257234502
G1X-14,998894564082Y5,21901426837162
X-15,0010592663063Y-5
X5Y-5
G0Z-30
M1";
            }
            set
            {
                _progText = value;
            }
        }

        public void RequestNewFile()
        {
            throw new NotImplementedException();
        }
    }
}
