import React from 'react'
import Menu from './Menu';
import SearchBar from './SearchBar';
const Home = () => {
  return (
    <div>
    <div className="tm-main-content" id="top">
      <Menu></Menu>
      <SearchBar></SearchBar>
            
            <div className="tm-section-2">
                <div className="container">
                    <div className="row">
                        <div className="col text-center">
                            <h2 className="tm-section-title">We are here to help you?</h2>
                            <p className="tm-color-white tm-section-subtitle">Subscribe to get our newsletters</p>
                            <a href="#" className="tm-color-white tm-btn-white-bordered">Subscribe Newletters</a>
                        </div>                
                    </div>
                </div>        
            </div>
            
            <div className="tm-section tm-position-relative">
                <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 100 100" preserveAspectRatio="none" className="tm-section-down-arrow">
                    <polygon fill="#ee5057" points="0,0  100,0  50,60"></polygon>                   
                </svg> 
                <div className="container tm-pt-5 tm-pb-4">
                    <div className="row text-center">
                        <article className="col-sm-12 col-md-4 col-lg-4 col-xl-4 tm-article">                            
                            <i className="fa tm-fa-6x fa-legal tm-color-primary tm-margin-b-20"></i>
                            <h3 className="tm-color-primary tm-article-title-1">Level HTML Template by Tooplate website</h3>
                            <p>You are allowed to download, edit and use this template for your business or client websites.</p>
                            <a href="#" className="text-uppercase tm-color-primary tm-font-semibold">Continue reading...</a>
                        </article>
                        <article className="col-sm-12 col-md-4 col-lg-4 col-xl-4 tm-article">                            
                            <i className="fa tm-fa-6x fa-plane tm-color-primary tm-margin-b-20"></i>
                            <h3 className="tm-color-primary tm-article-title-1">Original Website Template Producer</h3>
                            <p>You are NOT allowed to re-distribute the downloadable template ZIP file on any website.</p>
                            <a href="#" className="text-uppercase tm-color-primary tm-font-semibold">Continue reading...</a>                            
                        </article>
                        <article className="col-sm-12 col-md-4 col-lg-4 col-xl-4 tm-article">                           
                            <i className="fa tm-fa-6x fa-life-saver tm-color-primary tm-margin-b-20"></i>
                            <h3 className="tm-color-primary tm-article-title-1">Contact us if you have any question</h3>
                            <p>If you see this template being distributed on any other site, that is an illegal copy.</p>
                            <a href="#" className="text-uppercase tm-color-primary tm-font-semibold">Continue reading...</a>                           
                        </article>
                    </div>        
                </div>
            </div>
            
            <div className="tm-section tm-section-pad tm-bg-gray" id="tm-section-4">
                <div className="container">
                    <div className="row">
                    <div className="col-sm-12 col-md-12 col-lg-4 col-xl-4 tm-recommended-container">
                            <div className="tm-bg-white">
                                <div className="tm-bg-primary tm-sidebar-pad">
                                    <h3 className="tm-color-white tm-sidebar-title">Recommended Places</h3>
                                    <p className="tm-color-white tm-margin-b-0 tm-font-light">Enamel pin cliche tilde, kitsch and VHS thundercats</p>
                                </div>
                                <div className="tm-sidebar-pad-2">
                                    <a href="#" className="media tm-media tm-recommended-item">
                                        <img src="img/tn-img-01.jpg" alt="Image"></img>
                                        <div className="media-body tm-media-body tm-bg-gray">
                                            <h4 className="text-uppercase tm-font-semibold tm-sidebar-item-title">Europe</h4>
                                        </div>                                        
                                    </a>
                                    <a href="#" className="media tm-media tm-recommended-item">
                                        <img src="img/tn-img-02.jpg" alt="Image"></img>
                                        <div className="media-body tm-media-body tm-bg-gray">
                                            <h4 className="text-uppercase tm-font-semibold tm-sidebar-item-title">Asia</h4>
                                        </div>
                                    </a>
                                    <a href="#" className="media tm-media tm-recommended-item">
                                        <img src="img/tn-img-03.jpg" alt="Image"></img>
                                        <div className="media-body tm-media-body tm-bg-gray">
                                            <h4 className="text-uppercase tm-font-semibold tm-sidebar-item-title">Africa</h4>
                                        </div>
                                    </a>
                                    <a href="#" className="media tm-media tm-recommended-item">
                                        <img src="img/tn-img-04.jpg" alt="Image"></img>
                                        <div className="media-body tm-media-body tm-bg-gray">
                                            <h4 className="text-uppercase tm-font-semibold tm-sidebar-item-title">South America</h4>
                                        </div>
                                    </a>
                                </div>
                            </div>                            
                        </div>
                        <div className="col-sm-12 col-md-12 col-lg-8 col-xl-8">
                            <div className="tm-article-carousel">                            
                                <article className="tm-bg-white mr-2 tm-carousel-item">
                                    <img src={require('../assest/img/img-01.jpg')} alt="Image" className="img-fluid"></img>
                                    <div className="tm-article-pad">
                                        <header><h3 className="text-uppercase tm-article-title-2">Nunc in felis aliquet metus luctus iaculis</h3></header>
                                        <p>Aliquam ac lacus volutpat, dictum risus at, scelerisque nulla. Nullam sollicitudin at augue venenatis eleifend. Nulla ligula ligula, egestas sit amet viverra id, iaculis sit amet ligula.</p>
                                        <a href="#" className="text-uppercase btn-primary tm-btn-primary">Get More Info.</a>
                                    </div>                                
                                </article>                    
                                <article className="tm-bg-white mr-2 tm-carousel-item">
                                <img src={require('../assest/img/img-02.jpg')} alt="Image" className="img-fluid"></img>
                                    <div className="tm-article-pad">
                                        <header><h3 className="text-uppercase tm-article-title-2">Sed cursus dictum nunc quis molestie</h3></header>
                                        <p>Pellentesque quis dui sit amet purus scelerisque eleifend sed ut eros. Morbi viverra blandit massa in varius. Sed nec ex eu ex tincidunt iaculis. Curabitur eget turpis gravida.</p>
                                        <a href="#" className="text-uppercase btn-primary tm-btn-primary">View Detail</a>
                                    </div>                                
                                </article>
                                <article className="tm-bg-white mr-2 tm-carousel-item">
                                  
                                    <img src={require('../assest/img/img-01.jpg')}alt="Image" className="img-fluid"></img>
                                    <div className="tm-article-pad">
                                        <header><h3 className="text-uppercase tm-article-title-2">Eget diam pellentesque interdum ut porta</h3></header>
                                        <p>Aenean finibus tempor nulla, et maximus nibh dapibus ac. Duis consequat sed sapien venenatis consequat. Aliquam ac lacus volutpat, dictum risus at, scelerisque nulla.</p>
                                        <a href="#" className="text-uppercase btn-primary tm-btn-primary">More Info.</a>
                                    </div>                                
                                </article>
                            </div>    
                        </div>
                        

                    </div>
                </div>
            </div>

            <div className="tm-bg-video">
                <div className="overlay">
                    <i className="fa fa-5x fa-play-circle tm-btn-play"></i>
                    <i className="fa fa-5x fa-pause-circle tm-btn-pause"></i>
                </div>
                <div className="tm-section tm-section-pad tm-bg-img" id="tm-section-5">                                                        
                    <div className="container ie-h-align-center-fix">
                        <div className="row tm-flex-align-center">
                            <div className="col-xs-12 col-md-12 col-lg-3 col-xl-3 tm-media-title-container">
                                <h2 className="text-uppercase tm-section-title-2">ASIA</h2>
                                <h3 className="tm-color-primary tm-font-semibold tm-section-subtitle-2">Singapore</h3>
                            </div>
                            <div className="col-xs-12 col-md-12 col-lg-9 col-xl-9 mt-0 mt-sm-3">
                                <div className="ml-auto tm-bg-white-shadow tm-pad tm-media-container">

                                    <article className="media tm-margin-b-20 tm-media-1">
                                        <img src="img/img-04.jpg" alt="Image"></img>
                                        <div className="media-body tm-media-body-1 tm-media-body-v-center">
                                            <h3 className="tm-font-semibold tm-article-title-3">Suspendisse vel est libero sem phasellus ac laoreet</h3>
                                            <p>Duis accumsan sagittis tortor in ultrices. Praesent tortor ante, fringilla ac nibh porttitor, fermentum commodo nulla.</p>
                                            <a href="#" className="text-uppercase tm-color-primary tm-font-semibold">Continue reading...</a>
                                        </div>                                
                                    </article>
                                    <article className="media tm-margin-b-20 tm-media-1">
                                        <img src="img/img-05.jpg" alt="Image"></img>
                                        <div className="media-body tm-media-body-1 tm-media-body-v-center">
                                            <h3 className="tm-font-semibold tm-article-title-3">Faucibus dolor ligula nisl metus auctor aliquet</h3>
                                            <p>Nunc in felis aliquet metus luctus iaculis vel et nisi. Nulla venenatis nisl orci, laoreet ultricies massa tristique id.</p>
                                            <a href="#" className="text-uppercase tm-color-primary tm-font-semibold">Continue reading...</a>
                                        </div>                                
                                    </article>
                                </div>                            
                            </div>
                        </div>
                    </div>
                </div>
            </div>           
            
            <div className="tm-section tm-section-pad tm-bg-img tm-position-relative" id="tm-section-6">
                <div className="container ie-h-align-center-fix">
                    <div className="row">
                        <div className="col-xs-12 col-sm-12 col-md-6 col-lg-6 col-xl-7">
                            <div id="google-map"></div>        
                        </div>
                        <div className="col-xs-12 col-sm-12 col-md-6 col-lg-6 col-xl-5 mt-3 mt-md-0">
                            <div className="tm-bg-white tm-p-4">
                                <form action="index.html" method="post" className="contact-form">
                                    <div className="form-group">
                                        <input type="text" id="contact_name" name="contact_name" className="form-control" placeholder="Name"  required/>
                                    </div>
                                    <div className="form-group">
                                        <input type="email" id="contact_email" name="contact_email" className="form-control" placeholder="Email"  required/>
                                    </div>
                                    <div className="form-group">
                                        <input type="text" id="contact_subject" name="contact_subject" className="form-control" placeholder="Subject"  required/>
                                    </div>
                                    <div className="form-group">
                                        <textarea id="contact_message" name="contact_message" className="form-control" rows="9" placeholder="Message" required></textarea>
                                    </div>
                                    <button type="submit" className="btn btn-primary tm-btn-primary">Send Message Now</button>
                                </form>
                            </div>                            
                        </div>
                    </div>        
                </div>
            </div>
            
            <footer className="tm-bg-dark-blue">
                <div className="container">
                    <div className="row">
                        <p className="col-sm-12 text-center tm-font-light tm-color-white p-4 tm-margin-b-0">
                        Copyright &copy; <span className="tm-current-year">2018</span> Your Company
                        
                        - Design: <a rel="nofollow" href="https://www.tooplate.com" className="tm-color-primary tm-font-normal" target="_parent">Tooplate</a></p>        
                    </div>
                </div>                
            </footer>
        </div>
    </div>
  )
}
export default Home;
