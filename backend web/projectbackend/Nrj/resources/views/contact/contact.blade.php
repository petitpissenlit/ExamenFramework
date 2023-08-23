@extends('layouts.app')

@section('content')
    <div class="container">
        @if (session('success'))
            <div class="alert alert-success">
                {{ session('success') }}
            </div>
        @endif
        
        <h1>Contacteer ons</h1>
        <form method="POST" action="{{ route('contact.store') }}">
            @csrf
            <div class="form-group">
                <label for="name">Naam</label>
                <input type="text" name="name" class="form-control" required>
            </div>
            <div class="form-group">
                <label for="email">E-mailadres</label>
                <input type="email" name="email" class="form-control" required>
            </div>
            <div class="form-group">
                <label for="phone">Telefoonnummer</label>
                <input type="text" name="phone" class="form-control" required>
            </div>
            <div class="form-group">
                <label for="message">Bericht</label>
                <textarea name="message" class="form-control" required></textarea>
            </div>
            <button type="submit" class="btn btn-primary">Verzenden</button>
        </form>
    </div>
@endsection
