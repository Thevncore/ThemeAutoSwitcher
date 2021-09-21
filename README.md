# ThemeAutoSwitcher
Dark/light mode auto switcher for windows 10. Instant action when combined with startup compared to Task scheduler.

A common way to auto switch system theme based on time of day is to schedule a simple task, as described [here](https://www.windowscentral.com/how-switch-between-light-and-dark-colors-schedule-automatically-windows-10), [here](https://www.howtogeek.com/356087/how-to-automatically-enable-windows-10s-dark-theme-at-night/) and [here](https://answers.microsoft.com/en-us/windows/forum/all/night-lightdark-mode-task-scheduler/7c4e3d9a-34d4-4618-a16a-a0c1def4dc8c).

However, using task scheduler always introduce an inconvenience latency, which can be observed at startup. Using methods in the links above, the system theme will not be updated at startup (which is what it is supposed to do). Adding to the confusion, this behavior of waiting for about 10 minutes is contrary to "Run task as soon as possible after a scheduled start is missed" means, as described in [this SuperUser question](https://superuser.com/questions/1489426/what-could-be-causing-a-delay-in-scheduled-task-execution).

So, I propose a way to switch them instantly at startup. By placing this code into the Startup folder (or any equivalent places, such as Current User > Run), whenever the user logins, the code runs, and the theme gets switched instantly.
