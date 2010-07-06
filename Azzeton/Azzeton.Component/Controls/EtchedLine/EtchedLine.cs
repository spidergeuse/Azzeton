using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Azzeton.Components
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	public class EtchedLine : System.Windows.Forms.UserControl
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EtchedLine( )
		{
			InitializeComponent( );
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose( );
			}

			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
         // 
         // EtchedLine
         // 
         this.Name = "EtchedLine";
         this.Size = new System.Drawing.Size(192, 8);
         this.SizeChanged += new System.EventHandler(this.EtchedLine_SizeChanged);
         this.Paint += new System.Windows.Forms.PaintEventHandler(this.EtchedLine_Paint);

      }
		#endregion

      private void EtchedLine_Paint( object sender, System.Windows.Forms.PaintEventArgs e )
      {
         int iStartHeight = 0;
         
         if( LinePosition == DrawPosition.Middle )
            iStartHeight = Height / 2;
         else if( LinePosition == DrawPosition.Bottom )
            iStartHeight = Height - 1;

         switch( Sunken )
         {
         case DrawType.Etched:
			   e.Graphics.DrawLine( Pens.White, new Point( 0, iStartHeight - 1 ), new Point( Width, iStartHeight - 1 ));
            e.Graphics.DrawLine( Pens.Gray,  new Point( 0, iStartHeight     ), new Point( Width, iStartHeight     ));
            break;
         
         case DrawType.Raised:
            e.Graphics.DrawLine( Pens.Gray,  new Point( 0, iStartHeight - 1 ), new Point( Width, iStartHeight - 1 ));
            e.Graphics.DrawLine( Pens.White, new Point( 0, iStartHeight     ), new Point( Width, iStartHeight     ));
            break;

         case DrawType.White:
            e.Graphics.DrawLine( Pens.White, new Point( 0, iStartHeight     ), new Point( Width, iStartHeight     ));
            break;

         case DrawType.Gray:
            e.Graphics.DrawLine( Pens.Gray,  new Point( 0, iStartHeight     ), new Point( Width, iStartHeight     ));
            break;
         }
      }

      public enum DrawType { Etched, Raised, White, Gray };

      [DefaultValue( DrawType.Etched )]
      public DrawType Sunken
      {
         get{ return m_eSunken;  }
         set{ m_eSunken = value;  }
      }

      private DrawType m_eSunken = DrawType.Etched;


      [DefaultValue( DrawPosition.Middle )]
      public DrawPosition LinePosition
      {
         get{ return m_eLinePosition;  }
         set{ m_eLinePosition = value; }
      }

      public enum DrawPosition { Top, Middle, Bottom };
      private DrawPosition m_eLinePosition = DrawPosition.Middle;

      private void EtchedLine_SizeChanged(object sender, System.EventArgs e)
      {
         Invalidate( );
      }
	}
}
