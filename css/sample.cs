html {
  font-size: 62.5%; }

header {
  background: #eaf2f4; }
  header #header_in {
    padding-top: 10px;
    padding-bottom: 4px; }
  @media (max-width: 550px) {
    header .logo {
      width: 190px; }
    header .navi {
      width: 40px;
      float: right; } }
  header .sp_navi_li {
    width: 180px;
    position: absolute;
    top: 50px;
    right: 2%;
    z-index: 100;
    border: 1px solid #eee;
    background: white;
    margin: 0;
    padding: 0;
    display: none; }
    header .sp_navi_li li {
      list-style: none;
      margin: 0;
      padding: 0; }
      header .sp_navi_li li a {
        display: block;
        padding: 10px 8px;
        border-bottom: 1px solid #eee;
        font-size: 14px;
        text-decoration: none; }
  @media (min-width: 551px) {
    header .sp_navi {
      display: none; }
    header #header_in {
      padding: 15px 0 10px 0; }
    header .pc_navi_li {
      margin: 0;
      padding: 0; }
      header .pc_navi_li li {
        list-style: none;
        margin: 5px 0 0 0;
        padding: 0; }
        header .pc_navi_li li a {
          color: #626262;
          text-decoration: none;
          font-weight: bold;
          font-size: 14px;
          font-size: 1.4rem;
          float: left;
          padding-right: 10px; }
        header .pc_navi_li li a:hover {
          color: #42b9d0; }
      header .pc_navi_li li.navi_toppage a {
        background-repeat: no-repeat;
        display: inline-block;
        line-height: 40px;
        padding-left: 50px;
        background-image: url("../images/top/navi_top.png");
        background-size: 40px 40px; } }
    @media screen and (min-width: 551px) and (-webkit-min-device-pixel-ratio: 2), (min-width: 551px) and (min-resolution: 2dppx) {
      header .pc_navi_li li.navi_toppage a {
        background-image: url("../images/top/navi_top@2x.png"); } }
  @media (min-width: 551px) {
      header .pc_navi_li li.navi_news a {
        background-repeat: no-repeat;
        display: inline-block;
        line-height: 40px;
        padding-left: 50px;
        background-image: url("../images/top/navi_news.png");
        background-size: 40px 40px; } }
    @media screen and (min-width: 551px) and (-webkit-min-device-pixel-ratio: 2), (min-width: 551px) and (min-resolution: 2dppx) {
      header .pc_navi_li li.navi_news a {
        background-image: url("../images/top/navi_news@2x.png"); } }
  @media (min-width: 551px) {
      header .pc_navi_li li.navi_company a {
        background-repeat: no-repeat;
        display: inline-block;
        line-height: 40px;
        padding-left: 50px;
        background-image: url("../images/top/navi_company.png");
        background-size: 40px 40px; } }
    @media screen and (min-width: 551px) and (-webkit-min-device-pixel-ratio: 2), (min-width: 551px) and (min-resolution: 2dppx) {
      header .pc_navi_li li.navi_company a {
        background-image: url("../images/top/navi_company@2x.png"); } }

  @media (max-width: 550px) {
    header .pc_navi {
      display: none; } }

#cover_area {
  text-align: center;
  padding: 80px 0;
  background-image: url("../images/top/cover.jpg");
  background-size: cover; }
  @media screen and (-webkit-min-device-pixel-ratio: 2), (min-resolution: 2dppx) {
    #cover_area {
      background-image: url("../images/top/cover@2x.jpg"); } }
  @media (min-width: 551px) {
    #cover_area {
      text-align: left;
      height: 420px;
      padding: 0; }
      #cover_area img {
        margin-top: 180px;
        margin-left: 70px; } }

#service_area {
  padding-top: 20px; }
  @media (min-width: 551px) {
    #service_area {
      padding-top: 30px; } }
  #service_area .columns {
    color: #626262; }
    #service_area .columns .service_title {
      font-size: 18px;
      font-size: 1.8rem;
      font-weight: bold;
      margin-top: 8px; }
    #service_area .columns p {
      font-size: 15px;
      font-size: 1.5rem;
      margin-top: 10px; }
    @media (min-width: 551px) {
      #service_area .columns .service_title {
        font-size: 16px;
        font-size: 1.6rem; }
      #service_area .columns p {
        font-size: 13px;
        font-size: 1.3rem; } }

#news_area {
  background-color: #eaf2f4; }
  @media (min-width: 551px) {
    #news_area .container {
      padding: 0px 10% 50px 10%; } }
  #news_area .news_title {
    text-align: center;
    font-size: 26px;
    font-size: 2.6rem;
    color: #42b9d0;
    padding: 15px 0 10px 0;
    font-weight: bold;
    letter-spacing: 0.2rem; }
  #news_area .news_lists li {
    list-style: none;
    font-size: 15px;
    font-size: 1.5rem; }
    #news_area .news_lists li span {
      color: #42b9d0;
      font-weight: bold;
      display: block;
      margin-bottom: 3px; }
  @media (min-width: 551px) {
    #news_area .news_title {
      font-size: 22px;
      font-size: 2.2rem;
      padding: 50px 0 41px 0; }
    #news_area .news_lists li {
      font-size: 14px;
      font-size: 1.4rem;
      margin-bottom: 20px; }
      #news_area .news_lists li span {
        display: inline;
        margin-bottom: 0px; } }

footer {
  background-color: #42b9d0;
  color: #fff;
  padding-top: 20px; }
  @media (max-width: 550px) {
    footer .container {
      position: relative;
      max-width: 960px;
      width: 100%;
      margin: 0 auto;
      padding: 0;
      box-sizing: border-box;
      margin: 0; } }
  @media (max-width: 550px) and (min-width: 400px) {
    footer .container {
      padding: 0 20px; } }
  @media (max-width: 550px) {
    footer .sp {
      padding: 0 6%;
      margin: 0 auto; }
    footer .foot_navi {
      margin-top: 20px; }
      footer .foot_navi li {
        list-style: none;
        margin-bottom: 1px; }
        footer .foot_navi li a {
          color: #42b9d0;
          background-color: #eaf2f4;
          display: block;
          text-align: center;
          font-weight: bold;
          text-decoration: none;
          font-size: 16px;
          font-size: 1.6rem;
          padding: 16px 0; } }
  footer .foot_address {
    font-size: 16px;
    font-size: 1.6rem;
    padding-top: 10px; }
  footer .copy {
    text-align: center;
    font-size: 11px;
    font-size: 1.1rem;
    color: #b2e1ea; }
  @media (min-width: 551px) {
    footer {
      padding-top: 30px; }
      footer .foot_address {
        padding: 0px;
        font-size: 12px;
        font-size: 1.2rem; }
      footer .foot_navi {
        float: right; }
        footer .foot_navi li {
          list-style: none;
          background-repeat: no-repeat;
          background-position: left center;
          display: inline-block;
          float: left;
          margin-right: 10px;
          font-size: 11px;
          font-size: 1.1rem;
          background-image: url("../images/top/foot_arroehead.png");
          background-size: 4px 6px; } }
      @media screen and (min-width: 551px) and (-webkit-min-device-pixel-ratio: 2), (min-width: 551px) and (min-resolution: 2dppx) {
        footer .foot_navi li {
          background-image: url("../images/top/foot_arroehead@2x.png"); } }
  @media (min-width: 551px) {
        footer .foot_navi a {
          color: white;
          padding-left: 10px;
          text-decoration: none; }
        footer .foot_navi a:hover {
          color: #eaf2f4; }
      footer .copy {
        margin-top: 30px; } }

h1 {
  margin: 0;
  padding: 0; }

#sub_cover {
  text-align: center;
  padding: 80px 0;
  background-image: url("../images/news/sub_cover.jpg");
  width: 100%;
  background-size: cover;
  background-repeat: no-repeat;
  background-position: left; }
  @media screen and (-webkit-min-device-pixel-ratio: 2), (min-resolution: 2dppx) {
    #sub_cover {
      background-image: url("../images/news/sub_cover@2x.jpg"); } }
  @media screen and (-webkit-min-device-pixel-ratio: 2) and (max-width: 550px), (min-resolution: 2dppx) and (max-width: 550px) {
    #sub_cover {
      height: 50%; } }

  #sub_cover h2 {
    text-align: center;
    color: white;
    font-size: 16px;
    font-size: 1.6rem;
    font-weight: bold;
    margin: 0;
    letter-spacing: 0.2rem; }
    @media (min-width: 551px) {
      #sub_cover h2 {
        font-size: 32px; } }

#contents {
  padding-top: 35px;
  padding-bottom: 20px; }
  @media (min-width: 551px) {
    #contents {
      padding-bottom: 70px; } }
  #contents .container {
    padding: 0 20; }
    #contents .container #main {
      padding-right: 20px; }
    #contents .container h2 {
      color: #42b9d0;
      font-size: 20px;
      font-size: 2.0rem;
      font-weight: bold;
      padding-bottom: 15px;
      border-bottom: 3px solid #42b9d0;
      margin-bottom: 20; }
    #contents .container li {
      list-style: none; }
    #contents .container span {
      color: #42b9d0;
      display: block;
      font-weight: bold; }
      @media (min-width: 551px) {
        #contents .container span {
          display: inline-block; } }

.pc_sidemenu {
  color: #42b9d0;
  font-size: 14px;
  font-size: 1.4rem;
  padding: 0px;
  margin-bottom: 0px; }
  @media (max-width: 550px) {
    .pc_sidemenu {
      display: none; } }
  .pc_sidemenu h3 {
    color: #42b9d0;
    font-size: 14px;
    font-size: 1.4rem;
    letter-spacing: 0.2rem;
    font-weight: bold;
    background-color: #f3f9fb;
    padding: 15px;
    margin-bottom: 0px; }
  .pc_sidemenu li {
    list-style: none;
    display: block;
    border-bottom: 1px solid #e5e5e5;
    background-repeat: no-repeat;
    background-position: 8px center;
    margin-bottom: 0px;
    padding: 10px 10px 10px 20px;
    background-image: url("../images/news/side_arrow.png");
    background-size: 4px 6px; }
    @media screen and (-webkit-min-device-pixel-ratio: 2), (min-resolution: 2dppx) {
      .pc_sidemenu li {
        background-image: url("../images/news/side_arrow@2x.png"); }
        .pc_sidemenu li a {
          color: #339fd1;
          text-decoration: none; } }

.company_title {
  margin-bottom: 0; }

#contents .container #main {
  padding-right: 20px; }
  @media (max-width: 550px) {
    #contents .container #main {
      padding-right: 0px; } }

#main td {
  padding: 20px 0;
  color: #626262;
  font-size: 14px;
  font-size: 1.4rem; }

/*# sourceMappingURL=sample.cs.map */
