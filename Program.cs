// See https://aka.ms/new-console-template for more information

using Earpods;
using Earpods.Services;

var musicService = new MusicService();
var phoneService = new  PhoneService();
var earpods = new Earpods.Earpods(musicService, phoneService);

earpods.SingleTapRight();
earpods.DoubleTapLeft();
earpods.DoubleTapRight();

phoneService.TriggerCall();

earpods.SingleTapRight();
earpods.SingleTapLeft();
