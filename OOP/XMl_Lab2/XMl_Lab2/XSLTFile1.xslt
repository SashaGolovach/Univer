<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html"/>

    <xsl:template match="MovieBase">
      <html>
        <body>
          <h2 style="color:darkolivegreen;" >My movie base</h2>
          <table border="1" width="600">
            <tr bgcolor="#556B2F">
              <th height="30" style="color:ivory;" >Name</th>
              <th height="30" style="color:ivory;">Genre</th>
              <th height="30" style="color:ivory;">Studio</th>
              <th height="30" style="color:ivory;">Year</th>
              <th height="30" style="color:ivory;">Time</th>
            </tr>
                <xsl:for-each select="//movie">
                  <xsl:sort select="@NAME" />
                <tr>
                  <td width="300" height="50" style="color:darkolivegreen; font-style: Times New Roman; font-weight:bold;" >
                    <xsl:value-of select="@NAME"/>
                  </td>
                  <td width="200" height="50" style="color:darkolivegreen; font-style:Times New Roman; font-weight:bold;">
                    <xsl:value-of select="../ancestor::genre/@GENRE"/>
                  </td>
                  <td width="200" height="50" style="color:darkolivegreen; font-style: Times New Roman; font-weight:bold;">
                    <xsl:value-of select="../@STUDIO"/>
                  </td>
                  <td width="100" height="50" style="color:darkolivegreen; font-style: Times New Roman; font-weight:bold;">
                    <xsl:value-of select="@YEAR"/>
                  </td>
                  <td width="100" height="50" style="color:darkolivegreen; font-style: Times New Roman; font-weight:bold;">
                    <xsl:value-of select="@TIME"/>
                  </td>
                </tr>
            </xsl:for-each>
          </table>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
