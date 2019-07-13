# FFXIV Collect Helper

An unofficial companion app for https://collect.raelys.com/ which obtains a
character's collection information from the game data automatically and exports
it to the collection website.

## Why?

The FFXIV Collect website supports filling the collection information
automatically from the Lodestone, but that only covers the information present
there: mounts, achievements, minions, and a few more things.

The approach of collecting information directly from the game allows the
automated collect of much more information -- pretty much anything is fair
game. Bardings, emotes, orchestrions, triple triad cards, hairstyles, etc.

## How?

Like most FFXIV third-party apps, this companion app uses the Machina library
written by Ravahn. [More info](https://github.com/ravahn/machina). The app
inspects traffic sent by the FFXIV server to the game client at login time,
and reads out the collection information from there.

## Current status

This app is at the moment completely WIP. Use at your own risk, and it doesn't
do much for now.
