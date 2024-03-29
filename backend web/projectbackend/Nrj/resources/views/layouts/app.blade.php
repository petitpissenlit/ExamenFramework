<!doctype html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- CSRF Token -->
    <meta name="csrf-token" content="{{ csrf_token() }}">

    <title>{{ config('app.name', 'Laravel') }}</title>

    <!-- Fonts -->
    <link rel="dns-prefetch" href="//fonts.bunny.net">
    <link href="https://fonts.bunny.net/css?family=Nunito" rel="stylesheet">

    <!-- Scripts -->
    @vite(['resources/sass/app.scss', 'resources/js/app.js'])
</head>
<body>
    <div id="app">
        <nav class="navbar navbar-expand-md navbar-light bg-white shadow-sm">
            <div class="container">
                <a class="navbar-brand" href="{{ url('/') }}">
                    Nrj Solutions
                </a>
                
                

                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="{{ __('Toggle navigation') }}">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <!-- Left Side Of Navbar -->
                    <ul class="navbar-nav me-auto">
                        <li class="nav-item">
                            <a class="nav-link" href="{{ route('contact.store') }}">
                                Contact
                            </a>
                        </li>

                        <li class="nav-item">
                            @if (Auth::check() && Auth::user()->is_admin)
                            <a class="nav-link" href="{{ route('contact.admin') }}">Contactbeheer</a>
                            @endif
                        </li>

                        
                @auth
                <li class="nav-item">
                     @if (Auth::check() && Auth::user()->is_admin)
                <a class="nav-link"
                 href="{{route('posts.create')}}">New Post</a>
                 @endif
                @endauth

                    </ul>

                    <!-- Right Side Of Navbar -->
                    <ul class="navbar-nav ms-auto">


                        <!-- Andere inhoud van app.blade.php -->
                        @if (Auth::check() && Auth::user()->is_admin)
                            <a class="nav-link"href="{{ route('admin.users') }}">Gebruikersbeheer</a>
                        @endif
                        <!-- Andere inhoud van app.blade.php -->


                         <!-- Knop naar beheer FAQ-categorieën -->
                        
                        <li class="nav-item">
                            <a class="nav-link" href="{{ route('faq.index') }}"> FAQ-categorieën</a>
                        </li>


                        

                        <!-- Knop naar beheer FAQ vraag- en antwoordparen -->
                        
                        <li class="nav-item">
                            <a class="nav-link" href="{{ route('faq.categories') }}">Beheer FAQ </a>
                        </li>
                        

                         <!-- Knop naar profiel -->
                         @auth
                        <li class="nav-item">
                            <a class="nav-link" href="{{ route('profile', ['name' => Auth::user()->name]) }}">Profiel</a>
                        </li>
                        @endauth
                        <!-- Authentication Links -->
                        @guest
                            @if (Route::has('login'))
                                <li class="nav-item">
                                    <a class="nav-link" href="{{ route('login') }}">{{ __('Login') }}</a>
                                </li>
                            @endif

                            @if (Route::has('register'))
                                <li class="nav-item">
                                    <a class="nav-link" href="{{ route('register') }}">{{ __('Register') }}</a>
                                </li>
                            @endif
                        @else
                            <li class="nav-item dropdown">
                                <a id="navbarDropdown" class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-haspopup="true" aria-expanded="false" v-pre>
                                    {{ Auth::user()->name }}
                                </a>

                                <div class="dropdown-menu dropdown-menu-end" aria-labelledby="navbarDropdown">
                                    <a class="dropdown-item" href="{{ route('logout') }}"
                                       onclick="event.preventDefault();
                                                     document.getElementById('logout-form').submit();">
                                        {{ __('Logout') }}
                                    </a>

                                    <form id="logout-form" action="{{ route('logout') }}" method="POST" class="d-none">
                                        @csrf
                                    </form>
                                </div>
                            </li>
                        @endguest
                    </ul>
                </div>
            </div>
        </nav>

        <main class="py-4">
            @yield('content')
        </main>
    </div>
</body>
</html>
