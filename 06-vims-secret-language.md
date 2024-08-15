# Vim's Secret Language

This is a chapter for reflecting, consolidating your knowledge and appreciating how far you've come.

Write down all the operators, motions and commands that you've learned thus far. Don't take a look at the cheatsheet or any other reference. Just write down the ones that you can remember from the top of your head.

> Remember that you can use mnemonics to recall the commands based on what they do. Vim is really great at that.

```
Command - what does it do?
=============================
`j` - move cursor line own
`k` - move cursor line up
`h` - move cursor a character left
`l` - move cursor a character right

`w` - move to the first character of the next word (as a group of the same type of symbols)
 `W` - move to the first character of the next word (as a group of non-space type of symbols)
`b` - as `w` but opposite direction
`B` - as `W` but opposite direction
`e` - as `w` but to the last character
`E` - as `W` but to the last character
`ge` - reverse `e`

`0` - move to the first character of a line
`^` - ... to the first non-blank character ...
`$` - ... end of a line
`g_` - ... to the non-blank character at the end of a line

`{` - jumps entire paragraphs downwards 
`}` - the same upward
`CTRL-D` - move down half a page
`CTRL-U` - move up half a page

`f{'x'}` - place cursor at the next position 'x' in the string and keep normal mode
`F{'x'}` - '----' the previous '----'
`t{'x'}` - place cursor before position 'x' and keep normal mode
`;` - repeat

gg - go to the top of the file
`{line}gg` - go to a specific line
`G` - go to the end of the file
`%` - jump th matching ({[]})

`gd` - go to definition
`gf` - do to file

`/{pattern}` - to search forward including regex
`/{pattern}` - to search forward including regex
`?{pattern} - to search backward

{operator}{count}{motion}
    d for delete
    f for find
    c for change
    t for unTil


`a` - enter insert mode and input after the cursor
`A` - enter insert mode and take input at the end of the line
`i` - enter insert mode and take input before cursor position
`I` - enter insert mode and take input at the beginning of the current line
`o` - insert a new line after (below) the current and enter insert mode
`O` - insert a new line before (above) the current and enter insert mode
`gi` - enter the insert mode and out cursor at the last place you made a change

`CTRL-h` - delete the last character you typed (mnemonic _h_ which in _hjkl_)
`CTRL-w` - delete the last word you typed
`CTRL-u` - delete the last line you typed


```

When you're done write down the number of commands that you've learned and take a moment to celebrate how much you've learned! Wihoo! If you feel like it, share it with me on [twitter](https://twitter.com/Vintharas) and I'll give you a massive kudos. :D

Now dance!!

```
♪┏(・o･)┛♪┗ ( ･o･) ┓♪
```
