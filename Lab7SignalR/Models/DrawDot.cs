using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab7SignalR
{
    public class DrawDot : Hub
    {
        public void UpdateCanvas(int x, int y, string colorString)
        {
            Clients.All.updateDot(x, y, colorString);
        }

        public void ClearCanvas()
        {
            Clients.All.clearCanvas();
        }
    }
}