# Remote Clock
This software simply visualizes time and relevant information sent from an external program to control experiments involving several cameras and vocal start/stop instructions. This software allows you to transform a PC into a remote display where a common clock is visualized.

# Firewall Settings
This software receives messages through the UDP protocol using port 5555 (as the default, but you may change it). Therefore, you may need to set up an exception in your firewall to allow receiving the messages. Open the firewall settings and establish an inbound rule for UDP communications using the port you intend to use. Additionally, you may have to run this program as an administrator to ensure proper communication.

# Settings
Set up the port you are using and the color you intend to use for the background and font. Please note that background and text colors are switched according to the settings provided in the control software, also available in the main collection of repositories. If you check the option "Same color as the main display," colors will be controlled from the main software. For some older PCs, the visualization could be CPU intensive for large font sizes and in case of high refresh rates. You can tick the relevant option to reduce CPU usage. Click "START" to begin the visualization. If two displays are available, the second display will be used. In the case of a single display, the full display will be utilized, and you need to use Ctrl+S to stop the visualization.
