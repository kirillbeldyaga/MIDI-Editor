﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace MIDI_Library
{
    [DataContract]
    public class LineSecondExtFirstExt : Line
    {
        public LineSecondExtFirstExt()
        {
            this.Y = Staff.Staff_to_up + Staff.Between_staff_rows * 8 + Staff.Between_staff_rows / 2;
            Line_sName = MIDI_Library.NameLine.FirstExt;
            Note_sName = MIDI_Library.NoteName.H;
            Note_sOctave = MIDI_Library.NoteOctave.Small;
            Lines.Add(this);
        }
        public LineSecondExtFirstExt(int staffIndex)
        {
            this.Y = Staff.Staff_to_up + Staff.Between_staff_rows * 8 + Staff.Between_staff_rows / 2 + staffIndex * Staff.Between_staffs;
            Line_sName = MIDI_Library.NameLine.FirstExt;
            Note_sName = MIDI_Library.NoteName.H;
            Note_sOctave = MIDI_Library.NoteOctave.Small;
            StaffIndex = staffIndex;
            Lines.Add(this);
        }
        [DataMember]
        public int StaffIndex
        {
            get;
            set;
        }
        [DataMember]
        public NameLine Line_sName
        {
            get
            {
                return base.NameLine;
            }
            set
            {
                base.NameLine = MIDI_Library.NameLine.BetweenFirstExtraAndSecondExtra;
            }
        }
        [DataMember]
        public NoteName Note_sName
        {
            get
            {
                return base.NameNote;
            }
            set
            {
                base.NameNote = MIDI_Library.NoteName.H;
            }
        }
        [DataMember]
        public NoteOctave Note_sOctave
        {
            get
            {
                return base.OctaveNote;
            }
            set
            {
                base.OctaveNote = MIDI_Library.NoteOctave.Small;
            }
        }
        public override void Draw(BufferedGraphics g)
        {
            g.Graphics.DrawLine(Pens.Transparent, 25, Y, WidthOfLine, Y);
        }
        public override string ToString()
        {
            return Line_sName.ToString();
        }
    }
}
