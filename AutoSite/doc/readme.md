# AutoSite source documentation with Doxygen

This folder contains a [vbfilter](https://github.com/sevoku/Doxygen-VB-Filter) setup for Doxygen, to document the AutoSite source tree. The Doxygen Visual Basic filter is GPL2-licensed and created by Vsevolod Kukol.

To build source docs on Windows, you will need:
- gawk.exe in the same folder, from [GnuWin32](https://gnuwin32.sourceforge.net/packages/gawk.htm)
- Doxygen in your PATH, from [doxygen.nl](https://www.doxygen.nl/index.html)
- The AutoSite source repo cloned locally - not in a cloud folder. This makes sure Doxygen sees the files.

`make.bat` will build the docs with a modified vbfilter Doxyfile.

As doxygen creates lots of files, output folder html is currently git ignored.